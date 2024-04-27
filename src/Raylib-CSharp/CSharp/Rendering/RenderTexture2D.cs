using System.Runtime.InteropServices;
using Raylib_CSharp.CSharp.Rendering.Textures;

namespace Raylib_CSharp.CSharp.Rendering;

[StructLayout(LayoutKind.Sequential)]
public struct RenderTexture2D {
    
    /// <summary>
    /// OpenGL framebuffer object id.
    /// </summary>
    public uint Id;

    /// <summary>
    /// Color buffer attachment texture.
    /// </summary>
    public Texture2D Texture;

    /// <summary>
    /// Depth buffer attachment texture.
    /// </summary>
    public Texture2D Depth;
}