﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpGL
{
    // 用重载和枚举来简化GL编程。
    public static partial class GL
    {
        #region translate, rotate, scale

        /// <summary>
        /// This function applies a translation transformation to the current matrix.
        /// </summary>
        /// <param name="x">The amount to translate along the x axis.</param>
        /// <param name="y">The amount to translate along the y axis.</param>
        /// <param name="z">The amount to translate along the z axis.</param>
        public static void Translate(double x, double y, double z)
        {
            GL.Translated(x, y, z);
        }

        /// <summary>
        /// This function applies a translation transformation to the current matrix.
        /// </summary>
        /// <param name="x">The amount to translate along the x axis.</param>
        /// <param name="y">The amount to translate along the y axis.</param>
        /// <param name="z">The amount to translate along the z axis.</param>
        public static void Translate(float x, float y, float z)
        {
            GL.Translatef(x, y, z);
        }

        /// <summary>
        /// This function applies a rotation transformation to the current matrix.
        /// </summary>
        /// <param name="angle">The angle to rotate.</param>
        /// <param name="x">Amount along x.</param>
        /// <param name="y">Amount along y.</param>
        /// <param name="z">Amount along z.</param>
        public static void Rotate(double angle, double x, double y, double z)
        {
            GL.Rotated(angle, x, y, z);
        }

        /// <summary>
        /// This function applies a rotation transformation to the current matrix.
        /// </summary>
        /// <param name="angle">The angle to rotate.</param>
        /// <param name="x">Amount along x.</param>
        /// <param name="y">Amount along y.</param>
        /// <param name="z">Amount along z.</param>
        public static void Rotate(float angle, float x, float y, float z)
        {
            GL.Rotatef(angle, x, y, z);
        }

        /// <summary>
        /// This function applies a translation transformation to the current matrix.
        /// </summary>
        /// <param name="x">The amount to translate along the x axis.</param>
        /// <param name="y">The amount to translate along the y axis.</param>
        /// <param name="z">The amount to translate along the z axis.</param>
        public static void Scale(double x, double y, double z)
        {
            GL.Scaled(x, y, z);
        }

        /// <summary>
        /// This function applies a translation transformation to the current matrix.
        /// </summary>
        /// <param name="x">The amount to translate along the x axis.</param>
        /// <param name="y">The amount to translate along the y axis.</param>
        /// <param name="z">The amount to translate along the z axis.</param>
        public static void Scale(float x, float y, float z)
        {
            GL.Scalef(x, y, z);
        }

        #endregion translate, rotate, scale

        #region GL.Color

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 255).</param>
        /// <param name="green">Green color component (between 0 and 255).</param>
        /// <param name="blue">Blue color component (between 0 and 255).</param>
        public static void Color(byte red, byte green, byte blue)
        {
            GL.Color3ub(red, green, blue);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 255).</param>
        /// <param name="green">Green color component (between 0 and 255).</param>
        /// <param name="blue">Blue color component (between 0 and 255).</param>
        /// <param name="alpha">Alpha color component (between 0 and 255).</param>
        public static void Color(byte red, byte green, byte blue, byte alpha)
        {
            GL.Color4ub(red, green, blue, alpha);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        public static void Color(double red, double green, double blue)
        {
            GL.Color3d(red, green, blue);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        /// <param name="alpha">Alpha color component.</param>
        public static void Color(double red, double green, double blue, double alpha)
        {
            GL.Color4d(red, green, blue, alpha);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        public static void Color(float red, float green, float blue)
        {
            GL.Color3f(red, green, blue);
        }

        /// <summary>
        /// Sets the current color to 'v'.
        /// </summary>
        /// <param name="v">An array of either 3 or 4 float values.</param>
        public static void Color(float[] v)
        {
            int length = v.Length;
            if (length == 3) { GL.Color3fv(v); }
            else if (length == 4) { GL.Color4fv(v); }
            else { throw new ArgumentOutOfRangeException(); }
        }

        /// <summary>
        /// Sets the current color to 'v'.
        /// </summary>
        /// <param name="v">An array of either 3 or 4 int values.</param>
        public static void Color(int[] v)
        {
            int length = v.Length;
            if (length == 3) { GL.Color3iv(v); }
            else if (length == 4) { GL.Color4iv(v); }
            else { throw new ArgumentOutOfRangeException(); }
        }

        /// <summary>
        /// Sets the current color to 'v'.
        /// </summary>
        /// <param name="v">An array of either 3 or 4 int values.</param>
        public static void Color(short[] v)
        {
            int length = v.Length;
            if (length == 3) { GL.Color3sv(v); }
            else if (length == 4) { GL.Color4sv(v); }
            else { throw new ArgumentOutOfRangeException(); }
        }

        /// <summary>
        /// Sets the current color to 'v'.
        /// </summary>
        /// <param name="v">An array of either 3 or 4 double values.</param>
        public static void Color(double[] v)
        {
            int length = v.Length;
            if (length == 3) { GL.Color3dv(v); }
            else if (length == 4) { GL.Color4dv(v); }
            else { throw new ArgumentOutOfRangeException(); }
        }

        /// <summary>
        /// Sets the current color to 'v'.
        /// </summary>
        /// <param name="v">An array of either 3 or 4 byte values.</param>
        public static void Color(byte[] v)
        {
            int length = v.Length;
            if (length == 3) { GL.Color3bv(v); }
            else if (length == 4) { GL.Color4bv(v); }
            else { throw new ArgumentOutOfRangeException(); }
        }

        /// <summary>
        /// Sets the current color to 'v'.
        /// </summary>
        /// <param name="v">An array of either 3 or 4 unsigned int values.</param>
        public static void Color(uint[] v)
        {
            int length = v.Length;
            if (length == 3) { GL.Color3uiv(v); }
            else if (length == 4) { GL.Color4uiv(v); }
            else { throw new ArgumentOutOfRangeException(); }
        }

        /// <summary>
        /// Sets the current color to 'v'.
        /// </summary>
        /// <param name="v">An array of either 3 or 4 unsigned short values.</param>
        public static void Color(ushort[] v)
        {
            int length = v.Length;
            if (length == 3) { GL.Color3usv(v); }
            else if (length == 4) { GL.Color4usv(v); }
            else { throw new ArgumentOutOfRangeException(); }
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        public static void Color(int red, int green, int blue)
        {
            GL.Color3i(red, green, blue);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        /// <param name="alpha">Alpha color component.</param>
        public static void Color(int red, int green, int blue, int alpha)
        {
            GL.Color4i(red, green, blue, alpha);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        public static void Color(short red, short green, short blue)
        {
            GL.Color3s(red, green, blue);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        /// <param name="alpha">Alpha color component.</param>
        public static void Color(short red, short green, short blue, short alpha)
        {
            GL.Color4s(red, green, blue, alpha);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        public static void Color(uint red, uint green, uint blue)
        {
            GL.Color3ui(red, green, blue);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        /// <param name="alpha">Alpha color component.</param>
        public static void Color(uint red, uint green, uint blue, uint alpha)
        {
            GL.Color4ui(red, green, blue, alpha);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        public static void Color(ushort red, ushort green, ushort blue)
        {
            GL.Color3us(red, green, blue);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        /// <param name="alpha">Alpha color component.</param>
        public static void Color(ushort red, ushort green, ushort blue, ushort alpha)
        {
            GL.Color4us(red, green, blue, alpha);
        }

        /// <summary>
        /// Sets the current color.
        /// </summary>
        /// <param name="red">Red color component (between 0 and 1).</param>
        /// <param name="green">Green color component (between 0 and 1).</param>
        /// <param name="blue">Blue color component (between 0 and 1).</param>
        /// <param name="alpha">Alpha color component (between 0 and 1).</param>
        public static void Color(float red, float green, float blue, float alpha)
        {
            GL.Color4f(red, green, blue, alpha);
        }

        #endregion GL.Color

        #region GL.Vertex

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        public static void Vertex(double x, double y)
        {
            GL.Vertex2d(x, y);
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="v">Specifies the coordinate.</param>
        public static void Vertex(double[] v)
        {
            int length = v.Length;
            if (length == 2) { GL.Vertex2dv(v); }
            else if (length == 3) { GL.Vertex3dv(v); }
            else if (length == 4) { GL.Vertex4dv(v); }
            else { throw new ArgumentOutOfRangeException(); }
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        public static void Vertex(float x, float y)
        {
            GL.Vertex2f(x, y);
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        public static void Vertex(int x, int y)
        {
            GL.Vertex2i(x, y);
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="v">Specifies the coordinate.</param>
        public static void Vertex(int[] v)
        {
            int length = v.Length;
            if (length == 2) { GL.Vertex2iv(v); }
            else if (length == 3) { GL.Vertex3iv(v); }
            else if (length == 4) { GL.Vertex4iv(v); }
            else { throw new ArgumentOutOfRangeException(); }
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        public static void Vertex(short x, short y)
        {
            GL.Vertex2s(x, y);
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="v">Specifies the coordinate.</param>
        public static void Vertex(short[] v)
        {
            int length = v.Length;
            if (length == 2) { GL.Vertex2sv(v); }
            else if (length == 3) { GL.Vertex3sv(v); }
            else if (length == 4) { GL.Vertex4sv(v); }
            else { throw new ArgumentOutOfRangeException(); }
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        /// <param name="z">Z Value.</param>
        public static void Vertex(double x, double y, double z)
        {
            GL.Vertex3d(x, y, z);
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        /// <param name="z">Z Value.</param>
        public static void Vertex(float x, float y, float z)
        {
            GL.Vertex3f(x, y, z);
        }

        /// <summary>
        /// Sets the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="v">An array of 2, 3 or 4 floats.</param>
        public static void Vertex(float[] v)
        {
            int length = v.Length;
            if (length == 2) { GL.Vertex2fv(v); }
            else if (length == 3) { GL.Vertex3fv(v); }
            else if (length == 4) { GL.Vertex4fv(v); }
            else { throw new ArgumentOutOfRangeException(); }
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        /// <param name="z">Z Value.</param>
        public static void Vertex(int x, int y, int z)
        {
            GL.Vertex3i(x, y, z);
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        /// <param name="z">Z Value.</param>
        public static void Vertex(short x, short y, short z)
        {
            GL.Vertex3s(x, y, z);
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        /// <param name="z">Z Value.</param>
        /// <param name="w">W Value.</param>
        public static void Vertex(double x, double y, double z, double w)
        {
            GL.Vertex4d(x, y, z, w);
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        /// <param name="z">Z Value.</param>
        /// <param name="w">W Value.</param>
        public static void Vertex(float x, float y, float z, float w)
        {
            GL.Vertex4f(x, y, z, w);
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        /// <param name="z">Z Value.</param>
        /// <param name="w">W Value.</param>
        public static void Vertex(int x, int y, int z, int w)
        {
            GL.Vertex4i(x, y, z, w);
        }

        /// <summary>
        /// Set the current vertex (must be called between 'Begin' and 'End').
        /// </summary>
        /// <param name="x">X Value.</param>
        /// <param name="y">Y Value.</param>
        /// <param name="z">Z Value.</param>
        /// <param name="w">W Value.</param>
        public static void Vertex(short x, short y, short z, short w)
        {
            GL.Vertex4s(x, y, z, w);
        }

        #endregion GL.Vertex


    }
}
