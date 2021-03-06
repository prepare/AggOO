﻿using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace OpenTkEssTest
{
    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
         
            OpenTK.Toolkit.Init();



            int appcode = 7;
            switch (appcode)
            {

                case 1:
                    {
                        using (Textures example = new Textures())
                        {
                            // Get the title and category  of this example using reflection.
                            //ExampleAttribute info = ((ExampleAttribute)typeof(Textures).GetCustomAttributes(false)[0]);
                            // example.Title = String.Format("OpenTK | {0} {1}: {2}", info.Category, info.Difficulty, info.Title);
                            example.Run(30.0, 0.0);
                        }
                    } break;
                case 2:
                    {
                        //texture matrix
                        using (TextureMatrix example = new TextureMatrix())
                        {
                            // Get the title and category  of this example using reflection.
                            //ExampleAttribute info = ((ExampleAttribute)example.GetType().GetCustomAttributes(false)[0]);
                            //example.Title = String.Format("OpenTK | {0} {1}: {2}", info.Category, info.Difficulty, info.Title);
                            example.Run(30.0, 0.0);
                        }
                    } break;
                case 3:
                    {
                        using (T07_Display_Lists_Flower example = new T07_Display_Lists_Flower())
                        {
                            //Utilities.SetWindowTitle(example);
                            example.Run(30.0, 0.0);
                        }
                    } break;
                case 4:
                    {
                        using (T01_Basic example = new T01_Basic())
                        {
                            //Utilities.SetWindowTitle(example);
                            example.Run(30.0, 0.0);
                        }

                    } break;
                case 5:
                    {
                        using (T08_VBO example = new T08_VBO())
                        {
                            //Utilities.SetWindowTitle(example);
                            example.Run(30.0, 0.0);
                        }
                    } break;
                case 6:
                    {
                        // The 'using' idiom guarantees proper resource cleanup.
                        // We request 30 UpdateFrame events per second, and unlimited
                        // RenderFrame events (as fast as the computer can handle).
                        using (T09_VBO_Dynamic example = new T09_VBO_Dynamic())
                        {
                            //Utilities.SetWindowTitle(example);
                            example.Run(60.0, 0.0);
                        }
                    }break;
                case 7:
                    {
                        using (StencilCSG example = new StencilCSG())
                        {
                            //Utilities.SetWindowTitle(example);
                            example.Run(30.0, 0.0);
                        }
                    }break;

            }
        }
    }
}
