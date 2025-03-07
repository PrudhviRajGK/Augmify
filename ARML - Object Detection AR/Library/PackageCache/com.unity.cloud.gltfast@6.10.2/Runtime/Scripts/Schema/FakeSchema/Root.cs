// SPDX-FileCopyrightText: 2023 Unity Technologies and the glTFast authors
// SPDX-License-Identifier: Apache-2.0

using System.Runtime.CompilerServices;

namespace GLTFast.FakeSchema
{

    [System.Serializable]
    class Root
    {
        /// <summary>
        /// An array of materials. A material defines the appearance of a primitive.
        /// </summary>
        public Material[] materials;

#if GLTFAST_SAFE
        public Accessor[] accessors;
#endif

        public Mesh[] meshes;
    }
}
