﻿using Biohazrd;
using Biohazrd.CSharp;
using Biohazrd.Transformation;
using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;

namespace Mochi.DearImGui.Generator
{
    internal sealed class MochiDearImGuiNamespaceTransformation : TransformationBase
    {
        private readonly ConcurrentDictionary<TranslatedFile, string> NamespaceCache = new();

        protected override TranslatedLibrary PreTransformLibrary(TranslatedLibrary library)
        {
            Debug.Assert(NamespaceCache.Count == 0);
            NamespaceCache.Clear();
            return library;
        }

        protected override TranslatedLibrary PostTransformLibrary(TranslatedLibrary library)
        {
            NamespaceCache.Clear();
            return library;
        }

        protected override TransformationResult TransformDeclaration(TransformationContext context, TranslatedDeclaration declaration)
        {
            if (declaration is TranslatedParameter or TranslatedField or TranslatedEnumConstant)
            { return declaration; }

            string? namespaceName;

            // Check if we've seen this file before
            if (NamespaceCache.TryGetValue(declaration.File, out namespaceName))
            {
                return declaration with
                {
                    Namespace = namespaceName
                };
            }

            namespaceName = "Mochi.DearImGui";

            if (Path.GetFileName(declaration.File.FilePath) == "imgui_internal.h")
            { namespaceName += ".Internal"; }
            else if (Path.GetFileName(Path.GetDirectoryName(declaration.File.FilePath)) == "backends")
            {
                namespaceName += ".Backends";

                ReadOnlySpan<char> backendName = Path.GetFileNameWithoutExtension(declaration.File.FilePath);

                const string prefix = "imgui_impl_";
                if (backendName.StartsWith(prefix))
                { backendName = backendName.Slice(prefix.Length); }

                if (backendName.Length > 0)
                {
                    // Convert backend names to something more .NET-like
                    if (backendName.SequenceEqual("dx9"))
                    { namespaceName += ".Direct3D9"; }
                    else if (backendName.SequenceEqual("dx10"))
                    { namespaceName += ".Direct3D10"; }
                    else if (backendName.SequenceEqual("dx11"))
                    { namespaceName += ".Direct3D11"; }
                    else if (backendName.SequenceEqual("opengl2"))
                    { namespaceName += ".OpenGL2"; }
                    else if (backendName.SequenceEqual("opengl3"))
                    { namespaceName += ".OpenGL3"; }
                    else if (backendName.SequenceEqual("osx"))
                    { namespaceName += ".MacOS"; }
                    else if (backendName.SequenceEqual("wgpu"))
                    { namespaceName += ".WebGpu"; }
                    else
                    { namespaceName += $".{Char.ToUpperInvariant(backendName[0])}{backendName.Slice(1).ToString()}"; }
                }
            }

            // Retain namespaces form Dear ImGui (if present) with the exception of the main one
            if (declaration.Namespace is not null and not "ImGui")
            { namespaceName += $".{declaration.Namespace}"; }

            // Put native helpers generated by Biohazrd in a special infrastructure namespace
            if (declaration is ConstantArrayTypeDeclaration)
            { namespaceName += ".Infrastructure"; }

            // Cache the namespace for subsequent lookups
            NamespaceCache.TryAdd(declaration.File, namespaceName);

            return declaration with
            {
                Namespace = namespaceName
            };
        }
    }
}
