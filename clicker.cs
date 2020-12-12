if (siticoneTrackBar1.Minimum == 0)
            {
                siticoneTrackBar1.Minimum = 1;
            }
            if (siticoneMetroTrackBar2.Minimum == 0)
            {
                siticoneMetroTrackBar2.Minimum = 1;
            }
            int minval;
            int maxval;
            int cpsmed;
            if (checkBox1.Checked == true)
            {
                // jitter
            }
            else
            {
                cpsmed = rnd.Next(siticoneTrackBar1.Value, siticoneMetroTrackBar2.Value);
                if (siticoneTrackBar1.Minimum > 0)
                {
                    minval = 1000 / siticoneTrackBar1.Value + siticoneMetroTrackBar2.Value * (int)0.10;
                    maxval = 1000 / siticoneTrackBar1.Value + siticoneMetroTrackBar2.Value * (int)0.10;
                    timer1.Interval = rnd.Next(minval, maxval);
                }
                if (siticoneCustomCheckBox2.Checked == true)
                {
                    if (GetCaptionOfActiveWindow().Contains("Minecraft") || GetCaptionOfActiveWindow().Contains("Badlion") || GetCaptionOfActiveWindow().Contains("Labymod") || GetCaptionOfActiveWindow().Contains("OCMC") || GetCaptionOfActiveWindow().Contains("Cheatbreaker") || GetCaptionOfActiveWindow().Contains("Lunar Client"))
                    {
                        if (!ApplicationIsActivated())
                        {
                            if (MouseButtons == MouseButtons.Left)
                            {
                                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                                if (trackjitter.Value == 0)
                                {
                                    trackjitter.Value = 0;
                                }
                                int randx = rnd.Next(1, trackjitter.Value);
                                int randy = rnd.Next(1, trackjitter.Value);
                                int mX = MousePosition.X;
                                int mY = MousePosition.Y;
                                Cursor.Position = new Point(mX - randx, mY - randy);
                            }
                        }
                    }
                }
                else
                {
                    if (!ApplicationIsActivated())
                    {
                        if (MouseButtons == MouseButtons.Left)
                        {
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                            if (trackjitter.Value == 0)
                            {
                                trackjitter.Value = 0;
                            }
                            int randx = rnd.Next(0, trackjitter.Value);
                            int randy = rnd.Next(0, trackjitter.Value);
                            int mX = MousePosition.X;
                            int mY = MousePosition.Y;
                            Cursor.Position = new Point(mX - randx, mY - randy);
                        }
                    }
                }
            }
