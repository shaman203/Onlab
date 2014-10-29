using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace EEG_Marker
{

    public delegate void FrameViewer(Bitmap frame);
    public class VideoRecorder
    {
       
        //Create webcam object
        VideoCaptureDevice videoSource;
        FrameViewer handler;
        private bool doSave;
        private VideoFileWriter fileWriter; 
        private int width;
        private int height;
        private int frameRate;
         public VideoRecorder()
        {

        }
        public VideoRecorder( FrameViewer handler)
        {
            fileWriter = new VideoFileWriter();
            //List all available video sources. (That can be webcams as well as tv cards, etc)
            FilterInfoCollection videosources = new FilterInfoCollection(FilterCategory.VideoInputDevice);
 
            //Check if atleast one video source is available
            if (videosources != null)
            {
                        //For example use first video device. You may check if this is your webcam.
                        videoSource = new VideoCaptureDevice(videosources[0].MonikerString);
 
                        try
                        {
                            //Check if the video device provides a list of supported resolutions
                            if (videoSource.VideoCapabilities.Length > 0)
                            {
                                string highestSolution = "0;0";
                                //Search for the highest resolution
                                for (int i = 0; i < videoSource.VideoCapabilities.Length; i++)                                 {                                     if (videoSource.VideoCapabilities[i].FrameSize.Width > Convert.ToInt32(highestSolution.Split(';')[0]))
                                        highestSolution = videoSource.VideoCapabilities[i].FrameSize.Width.ToString() + ";" + i.ToString();
                                }
                                //Set the highest resolution as active
                                int resolution = Convert.ToInt32(highestSolution.Split(';')[1]);
                                videoSource.VideoResolution = videoSource.VideoCapabilities[resolution];
                                width = videoSource.VideoCapabilities[resolution].FrameSize.Width;
                                height = videoSource.VideoCapabilities[resolution].FrameSize.Height;
                                frameRate = videoSource.VideoCapabilities[resolution].AverageFrameRate;
                            }
                        }
                        catch { }
 
                        //Create NewFrame event handler
                        //(This one triggers every time a new frame/image is captured
                        this.handler = handler;
                        videoSource.NewFrame += new AForge.Video.NewFrameEventHandler(videoSource_NewFrame);
                       
            }
 
        }
 
        public void startRecording()
        {
            //Start recording
            videoSource.Start();
        }

        public void stopRecording()
        {
            stopSaving();
            //Stop and free the webcam object if application is closing
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
            }
           
        }

       

        public void startSaving(string filename)
        {
            doSave = true;
            fileWriter.Open(filename, width, height, frameRate);
        }

        public void stopSaving()
        {
            doSave = false;
            fileWriter.Close();
        }

      
        void videoSource_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            //Cast the frame as Bitmap object and don't forget to use ".Clone()" otherwise
            //you'll probably get access violation exceptions
            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            if (doSave && fileWriter.IsOpen)
            {
                fileWriter.WriteVideoFrame((Bitmap)image.Clone());
            }
            //image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            handler(image);
           
        }
    }
}
