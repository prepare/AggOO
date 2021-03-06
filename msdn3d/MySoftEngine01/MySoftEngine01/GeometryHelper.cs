﻿using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using SharpDX;

namespace SoftEngine
{
    public static class GeoHelper
    {
        public static Mesh CreateCube(float width)
        {
            //Mesh mesh = new Mesh("Cube", 8, 12);
            ////mesh.Vertices[0] = new Vector3(-1, 1, 1);
            ////mesh.Vertices[1] = new Vector3(1, 1, 1);
            ////mesh.Vertices[2] = new Vector3(-1, -1, 1);
            ////mesh.Vertices[3] = new Vector3(1, -1, 1);
            ////mesh.Vertices[4] = new Vector3(-1, 1, -1);
            ////mesh.Vertices[5] = new Vector3(1, 1, -1);
            ////mesh.Vertices[6] = new Vector3(1, -1, -1);
            ////mesh.Vertices[7] = new Vector3(-1, -1, -1);

            ////create at origin of object space
            //mesh.Vertices[0] = new Vector3(-width, width, width);
            //mesh.Vertices[1] = new Vector3(width, width, width);
            //mesh.Vertices[2] = new Vector3(-width, -width, width);
            //mesh.Vertices[3] = new Vector3(width, -width, width);
            //mesh.Vertices[4] = new Vector3(-width, width, -width);
            //mesh.Vertices[5] = new Vector3(width, width, -width);
            //mesh.Vertices[6] = new Vector3(width, -width, -width);
            //mesh.Vertices[7] = new Vector3(-width, -width, -width);

            //mesh.Faces[0] = new Face { A = 0, B = 1, C = 2 };
            //mesh.Faces[1] = new Face { A = 1, B = 2, C = 3 };
            //mesh.Faces[2] = new Face { A = 1, B = 3, C = 6 };
            //mesh.Faces[3] = new Face { A = 1, B = 5, C = 6 };
            //mesh.Faces[4] = new Face { A = 0, B = 1, C = 4 };
            //mesh.Faces[5] = new Face { A = 1, B = 4, C = 5 };

            //mesh.Faces[6] = new Face { A = 2, B = 3, C = 7 };
            //mesh.Faces[7] = new Face { A = 3, B = 6, C = 7 };
            //mesh.Faces[8] = new Face { A = 0, B = 2, C = 7 };
            //mesh.Faces[9] = new Face { A = 0, B = 4, C = 7 };
            //mesh.Faces[10] = new Face { A = 4, B = 5, C = 6 };
            //mesh.Faces[11] = new Face { A = 4, B = 6, C = 7 };
            //return mesh;
            return CreateCube(width, width, width);
        }
        public static Mesh CreateCube(float x, float y, float z)
        {
            Mesh mesh = new Mesh("Cube", 8, 12);
            //mesh.Vertices[0] = new Vector3(-1, 1, 1);
            //mesh.Vertices[1] = new Vector3(1, 1, 1);
            //mesh.Vertices[2] = new Vector3(-1, -1, 1);
            //mesh.Vertices[3] = new Vector3(1, -1, 1);
            //mesh.Vertices[4] = new Vector3(-1, 1, -1);
            //mesh.Vertices[5] = new Vector3(1, 1, -1);
            //mesh.Vertices[6] = new Vector3(1, -1, -1);
            //mesh.Vertices[7] = new Vector3(-1, -1, -1);

            mesh.Vertices[0] = new Vector3(-x, y, z);
            mesh.Vertices[1] = new Vector3(x, y, z);
            mesh.Vertices[2] = new Vector3(-x, -y, z);
            mesh.Vertices[3] = new Vector3(x, -y, z);
            mesh.Vertices[4] = new Vector3(-x, y, -z);
            mesh.Vertices[5] = new Vector3(x, y, -z);
            mesh.Vertices[6] = new Vector3(x, -y, -z);
            mesh.Vertices[7] = new Vector3(-x, -y, -z);

            mesh.Faces[0] = new Face { A = 0, B = 1, C = 2 };
            mesh.Faces[1] = new Face { A = 1, B = 2, C = 3 };
            mesh.Faces[2] = new Face { A = 1, B = 3, C = 6 };
            mesh.Faces[3] = new Face { A = 1, B = 5, C = 6 };
            mesh.Faces[4] = new Face { A = 0, B = 1, C = 4 };
            mesh.Faces[5] = new Face { A = 1, B = 4, C = 5 };

            mesh.Faces[6] = new Face { A = 2, B = 3, C = 7 };
            mesh.Faces[7] = new Face { A = 3, B = 6, C = 7 };
            mesh.Faces[8] = new Face { A = 0, B = 2, C = 7 };
            mesh.Faces[9] = new Face { A = 0, B = 4, C = 7 };
            mesh.Faces[10] = new Face { A = 4, B = 5, C = 6 };
            mesh.Faces[11] = new Face { A = 4, B = 6, C = 7 };
            return mesh;

        }
    }
}