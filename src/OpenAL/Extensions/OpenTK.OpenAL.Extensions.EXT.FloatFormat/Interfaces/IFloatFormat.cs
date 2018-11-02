using AdvancedDLSupport;

namespace OpenToolkit.OpenAL.Extensions.EXT.FloatFormat
{
    /// <summary>
    /// Defines the public interface for buffer-related functions of the multi-channel buffers extension.
    /// </summary>
    [NativeSymbols(Prefix = "al")]
    internal interface IFloatFormat
    {
        /// <summary>
        /// Fills a buffer with audio data.
        /// </summary>
        /// <param name="buffer">The buffer to fill.</param>
        /// <param name="format">The format of the data.</param>
        /// <param name="data">A pointer to the data.</param>
        /// <param name="size">The size of the data in bytes.</param>
        /// <param name="frequency">The frequency of the data.</param>
        unsafe void BufferData(uint buffer, FloatBufferFormat format, void* data, int size, int frequency);
    }
}
