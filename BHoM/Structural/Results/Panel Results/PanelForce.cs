﻿using BHoM.Base.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHoM.Structural.Results
{
    public class PanelForce : PanelForce<int, int, int>
    {
        public PanelForce() : base() { }
        public PanelForce(int number, int node, int loadcase, int timeStep, double fx, double fy, double fz, double mx, double my, double mz, double vx, double vy)
            : base(number, node, loadcase, timeStep, fx, fy, fz, mx, my, mz, vx, vy)
        { }
    }

    public class PanelForce<TName, TLoadcase, TTimeStep> : Result<TName, TLoadcase, TTimeStep>
         where TName : IComparable
         where TLoadcase : IComparable
         where TTimeStep : IComparable
    {
        public override string[] ColumnHeaders
        {
            get
            {
                return GetColumnHeaders();
            }
        }

        public static string[] GetColumnHeaders()
        {
            return new string[] { "Id", "Name", "Loadcase", "TimeStep", "Node", "NXX", "NYY", "NXY", "MXX", "MYY", "MXY", "VX", "VY" };
        }

        public override ResultType ResultType
        {
            get
            {
                return ResultType.PanelForce;
            }
        }

        public PanelForce()
        {
            Data = new object[13];
        }

        public PanelForce(object[] data) { Data = data; }

        public PanelForce(TName number, TName node, TLoadcase loadcase, TTimeStep timeStep, double nx, double ny, double nxy, double mx, double my, double mxy, double vx, double vy) : this()
        {
            Name = number;
            TimeStep = timeStep;
            Loadcase = loadcase;
            Node = node;
            Id = Name + ":" + Node + ":" + loadcase + ":" + TimeStep;
            NXX = nx;
            NYY = ny;
            NXY = nxy;
            MXX = mx;
            MYY = my;
            MXY = mxy;
            VX = vx;
            VY = vy;
        }

        public TName Node
        {
            get
            {
                return (TName)Data[4];
            }
            set
            {
                Data[4] = value;
            }
        }

        public double NXX
        {
            get
            {
                return (double)Data[5];
            }
            set
            {
                Data[5] = value;
            }
        }

        public double NYY
        {
            get
            {
                return (double)Data[6];
            }
            set
            {
                Data[6] = value;
            }
        }

        public double NXY
        {
            get
            {
                return (double)Data[7];
            }
            set
            {
                Data[7] = value;
            }
        }

        public double MXX
        {
            get
            {
                return (double)Data[8];
            }
            set
            {
                Data[8] = value;
            }
        }

        public double MYY
        {
            get
            {
                return (double)Data[9];
            }
            set
            {
                Data[9] = value;
            }
        }

        public double MXY
        {
            get
            {
                return (double)Data[10];
            }
            set
            {
                Data[10] = value;
            }
        }

        public double VX
        {
            get
            {
                return (double)Data[11];
            }
            set
            {
                Data[11] = value;
            }
        }
        public double VY
        {
            get
            {
                return (double)Data[12];
            }
            set
            {
                Data[12] = value;
            }
        }
    }
}