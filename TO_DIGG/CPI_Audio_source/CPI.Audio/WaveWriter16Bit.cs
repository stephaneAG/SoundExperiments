using System;
using System.IO;

namespace CPI.Audio
{
    /// <summary>
    /// A class to write 16-bit wave files.
    /// </summary>
    public class WaveWriter16Bit : WaveWriter
    {
        # region Constructors

        /// <summary>
        /// Instantiates a new WaveWriter16Bit object.
        /// </summary>
        /// <param name="output">A Stream object to write the wave to.</param>
        /// <param name="sampleRate">Specifies the sample rate (number of samples per second) of the wave file.</param>
        /// <param name="stereo">Specifies whether this is a mono or stereo wave file.</param>
        /// <remarks>
        /// When this object is disposed, it will close its underlying stream.  To change this default behavior,
        /// you can call an overloaded constructor which takes a closeUnderlyingStream parameter.
        /// </remarks>
        public WaveWriter16Bit(Stream output, int sampleRate, bool stereo)
            : base(output, sampleRate, 16, stereo, true) { }

        /// <summary>
        /// Instantiates a new WaveWriter16Bit object.
        /// </summary>
        /// <param name="output">A Stream object to write the wave to.</param>
        /// <param name="sampleRate">Specifies the sample rate (number of samples per second) of the wave file.</param>
        /// <param name="stereo">Specifies whether this is a mono or stereo wave file.</param>
        /// <param name="closeUnderlyingStream">
        /// Determines whether to close the the stream that the WaveWriter is writing to when the WaveWriter is closed.
        /// </param>
        public WaveWriter16Bit(Stream output, int sampleRate, bool stereo, bool closeUnderlyingStream)
            : base(output, sampleRate, 16, stereo, closeUnderlyingStream) { }



        # endregion

        # region Methods

        /// <summary>
        /// Reads a sample from the wave file.
        /// </summary>
        /// <returns>The data read from the wave file.</returns>
        public Sample16Bit Read()
        {
            ThrowIfDisposed();

            long initialPos = Reader.BaseStream.Position;

            try
            {
                if (Header.Stereo)
                {
                    return new Sample16Bit(Reader.ReadInt16(), Reader.ReadInt16());
                }
                else
                {
                    return new Sample16Bit(Reader.ReadInt16());
                }
            }
            catch
            {
                Reader.BaseStream.Position = initialPos;

                throw;
            }
        }

        /// <summary>
        /// Writes a sample to the wave file.
        /// </summary>
        /// <param name="sample">The sample information to write.</param>
        public void Write(Sample16Bit sample)
        {
            ThrowIfDisposed();

            long initialPos = Writer.BaseStream.Position;

            try
            {
                Writer.Write(sample.LeftChannel);

                if (Header.Stereo)
                    Writer.Write(sample.RightChannel);
            }
            catch
            {
                Writer.BaseStream.Position = initialPos;

                throw;
            }
            finally
            {
                if (CurrentSample > Header.NumberOfSamples)
                    Header.NumberOfSamples = CurrentSample;
            }
        }

        # endregion
    }
}
