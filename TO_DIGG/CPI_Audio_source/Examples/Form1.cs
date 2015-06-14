using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

using CPI.Audio;

namespace Examples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        # region Stereo Effect Method

        static void GenerateStereoEffect(WaveWriter16Bit writer)
        {
            double frequency = 261.626;

            double samplesPerCycle = writer.SampleRate / frequency;

            int totalSamples = 20 * writer.SampleRate;

            Sample16Bit sample = new Sample16Bit(true);

            for (int currentSample = 0; currentSample < totalSamples; currentSample++)
            {
                short rightVolume = (short)(((double)currentSample / totalSamples) * 32000);
                short leftVolume = (short)(32000 - rightVolume);

                double sampleValueRight = Math.Sin(currentSample / samplesPerCycle * 2 * Math.PI) * rightVolume;
                double sampleValueLeft = Math.Sin(currentSample / samplesPerCycle * 2 * Math.PI) * leftVolume;
                sample.LeftChannel = (short)sampleValueLeft;
                sample.RightChannel = (short)sampleValueRight;

                writer.Write(sample);
            }
        }

        # endregion

        # region "Minuet" Methods

        static void AddMinuetBass(SongWriter writer)
        {
            writer.CurrentBeat = 0;

            writer.AddNote(Tones.G3, 2);
            writer.CurrentBeat -= 2;
            writer.AddNote(Tones.B3, 2);
            writer.CurrentBeat -= 2;
            writer.AddNote(Tones.D4, 2);
            writer.AddNote(Tones.A3, 1);

            writer.AddNote(Tones.B3, 3);

            writer.AddNote(Tones.C4, 3);

            writer.AddNote(Tones.B3, 3);

            writer.AddNote(Tones.A3, 3);

            writer.AddNote(Tones.G3, 3);

            writer.AddNote(Tones.D4, .5);
            writer.AddRest(.5);
            writer.AddNote(Tones.B3, .5);
            writer.AddRest(.5);
            writer.AddNote(Tones.G3, 1);

            writer.AddNote(Tones.D4, 1);
            writer.AddNote(Tones.D3, .5);
            writer.AddNote(Tones.C4, .5);
            writer.AddNote(Tones.B3, .5);
            writer.AddNote(Tones.A3, .5);

            writer.AddNote(Tones.B3, 2);
            writer.AddNote(Tones.A3, 1);

            writer.AddNote(Tones.G3, 1);
            writer.AddNote(Tones.B3, .5);
            writer.AddRest(.5);
            writer.AddNote(Tones.G3, 1);

            writer.AddNote(Tones.C4, 3);

            writer.AddNote(Tones.B3, 1);
            writer.AddNote(Tones.C4, .5);
            writer.AddNote(Tones.B3, .5);
            writer.AddNote(Tones.A3, .5);
            writer.AddNote(Tones.G3, .5);

            writer.AddNote(Tones.A3, 2);
            writer.AddNote(Tones.FSharp3, 1);

            writer.AddNote(Tones.G3, 2);
            writer.AddNote(Tones.B3, 1);

            writer.AddNote(Tones.C4, 1);
            writer.AddNote(Tones.D4, 1);
            writer.AddNote(Tones.D3, 1);

            writer.AddNote(Tones.G3, 2);
            writer.AddRest(1);
        }

        static void AddMinuetMelody(SongWriter writer)
        {
            writer.CurrentBeat = 0;

            writer.AddNote(Tones.D5, 1);
            writer.AddNote(Tones.G4, .5);
            writer.AddNote(Tones.A4, .5);
            writer.AddNote(Tones.B4, .5);
            writer.AddNote(Tones.C5, .5);

            writer.AddNote(Tones.D5, 1);
            writer.AddNote(Tones.G4, .5);
            writer.AddRest(.5);
            writer.AddNote(Tones.G4, .5);
            writer.AddRest(.5);

            writer.AddNote(Tones.E5, 1);
            writer.AddNote(Tones.C5, .5);
            writer.AddNote(Tones.D5, .5);
            writer.AddNote(Tones.E5, .5);
            writer.AddNote(Tones.FSharp5, .5);

            writer.AddNote(Tones.G5, 1);
            writer.AddNote(Tones.G4, .5);
            writer.AddRest(.5);
            writer.AddNote(Tones.G4, .5);
            writer.AddRest(.5);

            writer.AddNote(Tones.C5, 1);
            writer.AddNote(Tones.D5, .5);
            writer.AddNote(Tones.C5, .5);
            writer.AddNote(Tones.B4, .5);
            writer.AddNote(Tones.A4, .5);

            writer.AddNote(Tones.B4, 1);
            writer.AddNote(Tones.C5, .5);
            writer.AddNote(Tones.B4, .5);
            writer.AddNote(Tones.A4, .5);
            writer.AddNote(Tones.G4, .5);

            writer.AddNote(Tones.FSharp4, 1);
            writer.AddNote(Tones.G4, .5);
            writer.AddNote(Tones.A4, .5);
            writer.AddNote(Tones.B4, .5);
            writer.AddNote(Tones.G4, .5);

            writer.AddNote(Tones.B4, .5 / 3);
            writer.AddNote(Tones.C5, .5 / 3);
            writer.AddNote(Tones.B4, .5 / 3);
            writer.AddNote(Tones.C5, .25);
            writer.AddNote(Tones.B4, .25);
            writer.AddNote(Tones.A4, 2);

            writer.AddNote(Tones.D5, 1);
            writer.AddNote(Tones.G4, .5);
            writer.AddNote(Tones.A4, .5);
            writer.AddNote(Tones.B4, .5);
            writer.AddNote(Tones.C5, .5);

            writer.AddNote(Tones.D5, 1);
            writer.AddNote(Tones.G4, .5);
            writer.AddRest(.5);
            writer.AddNote(Tones.G4, .5);
            writer.AddRest(.5);

            writer.AddNote(Tones.E5, 1);
            writer.AddNote(Tones.C5, .5);
            writer.AddNote(Tones.D5, .5);
            writer.AddNote(Tones.E5, .5);
            writer.AddNote(Tones.FSharp5, .5);

            writer.AddNote(Tones.G5, 1);
            writer.AddNote(Tones.G4, .5);
            writer.AddRest(.5);
            writer.AddNote(Tones.G4, .5);
            writer.AddRest(.5);

            writer.AddNote(Tones.C5, 1);
            writer.AddNote(Tones.D5, .5);
            writer.AddNote(Tones.C5, .5);
            writer.AddNote(Tones.B4, .5);
            writer.AddNote(Tones.A4, .5);

            writer.AddNote(Tones.B4, 1);
            writer.AddNote(Tones.C5, .5);
            writer.AddNote(Tones.B4, .5);
            writer.AddNote(Tones.A4, .5);
            writer.AddNote(Tones.G4, .5);

            writer.AddNote(Tones.A4, 1);
            writer.AddNote(Tones.B4, .5);
            writer.AddNote(Tones.A4, .5);
            writer.AddNote(Tones.G4, .5);
            writer.AddNote(Tones.FSharp4, .5);

            writer.AddNote(Tones.G4, 2);
            writer.AddRest(1);
        }

        # endregion

        # region "Push It" Methods

        static void AddPushItBass(SongWriter writer)
        {
            writer.CurrentBeat = 0;

            for (int i = 0; i < 4; i++)
            {
                writer.AddNote(Tones.A3, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.E3, 1);
                writer.AddNote(Tones.A3, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.E3, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.G3, 1);
                writer.AddRest(8);
                writer.AddNote(Tones.A3, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.E3, 1);
                writer.AddNote(Tones.A3, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.E3, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.G3, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.E3, 1);
                writer.AddNote(Tones.G3, 1);
                writer.AddNote(Tones.E3, 1);
                writer.AddNote(Tones.B3, 1);
                writer.AddNote(Tones.C4, 1);
                writer.AddNote(Tones.B3, 2);
            }
            writer.AddNote(Tones.A3, 1);
        }

        static void AddPushItMelody(SongWriter writer)
        {
            writer.CurrentBeat = 64;

            for (int i = 0; i < 2; i++)
            {
                writer.AddNote(Tones.A5, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.E6, 1);
                writer.AddNote(Tones.D6, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.C6, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.B5, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.G5, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.G5, 1);
                writer.AddNote(Tones.B5, 1);
                writer.AddNote(Tones.C6, 1);
                writer.AddNote(Tones.B5, 1);
                writer.AddNote(Tones.G5, 1);
                writer.AddNote(Tones.A5, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.E6, 1);
                writer.AddNote(Tones.D6, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.C6, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.B5, 1);
                writer.AddRest(1);
                writer.AddNote(Tones.G5, 1);
                writer.AddNote(Tones.F5, 1);
                writer.AddNote(Tones.G5, 1);
                writer.AddNote(Tones.B5, 1);
                writer.AddNote(Tones.C6, 1);
                writer.AddNote(Tones.B5, 1);
                writer.AddNote(Tones.G5, 1);
            }
            writer.AddNote(Tones.A5, 1);
        }

        # endregion

        # region 3 Stooges Method

        static void Generate3StoogesSong(SongWriter writer)
        {
            writer.DefaultVolume = 5000;

            // First voice
            writer.AddNote(Tones.C4, 1);  // Hel-
            writer.AddNote(Tones.C4, 15); // lo...

            // Jump back to where the second voice comes in
            writer.CurrentBeat = 4;

            // Second voice
            writer.AddNote(Tones.E4, 1);  // Hel-
            writer.AddNote(Tones.E4, 11); // lo...

            // Jump back to where the third voice comes in
            writer.CurrentBeat = 8;

            // Third voice
            writer.AddNote(Tones.G4, 1);  // Hel-
            writer.AddNote(Tones.G4, 7);  // lo!!
        }

        # endregion

        # region Event Handlers

        private void btnStereo_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    this.Refresh();

                    using (WaveWriter16Bit writer = new WaveWriter16Bit(new FileStream(saveDialog.FileName, FileMode.Create), 44100, true))
                    {
                        GenerateStereoEffect(writer);
                    }
                }

                MessageBox.Show("File generated.", "Complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("File generation failed with the following error message: " + Environment.NewLine + Environment.NewLine + ex.Message, ex.GetType().Name);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnTouchTones_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    this.Refresh();

                    using (TouchToneGenerator generator = new TouchToneGenerator(new FileStream(saveDialog.FileName, FileMode.Create)))
                    {
                        generator.GenerateTones(txtTouchTone.Text);
                    }

                    MessageBox.Show("File generated.", "Complete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File generation failed with the following error message: " + Environment.NewLine + Environment.NewLine + ex.Message, ex.GetType().Name);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnMinuetInG_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    this.Refresh();

                    using (SongWriter writer = new SongWriter(new FileStream(saveDialog.FileName, FileMode.Create), 160))
                    {
                        writer.DefaultVolume = 8000;

                        AddMinuetBass(writer);
                        AddMinuetMelody(writer);
                    }

                    MessageBox.Show("File generated.", "Complete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File generation failed with the following error message: " + Environment.NewLine + Environment.NewLine + ex.Message, ex.GetType().Name);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnPushIt_Click(object sender, EventArgs e)
        {
            try
            {
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    this.Refresh();

                    using (SongWriter writer = new SongWriter(new FileStream(saveDialog.FileName, FileMode.Create), 252))
                    {
                        writer.DefaultVolume = 8000;

                        AddPushItBass(writer);
                        AddPushItMelody(writer);
                    }
                    MessageBox.Show("File generated.", "Complete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File generation failed with the following error message: " + Environment.NewLine + Environment.NewLine + ex.Message, ex.GetType().Name);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnMemoryStream_Click(object sender, EventArgs e)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                using (SongWriter writer = new SongWriter(stream, 180, false))
                {
                    Generate3StoogesSong(writer);
                }

                // jump back to the beginning of the stream
                stream.Position = 0;

                using (SoundPlayer player = new SoundPlayer(stream))
                {
                    player.PlaySync();
                }
            }
        }

        # endregion

    }
}