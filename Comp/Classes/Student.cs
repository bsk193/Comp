﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class Student
    {
        public Student(Int64 studentNumber, String name, String classCode)
        {
            this.studentNumber = studentNumber; this.name = name; this.classCode = classCode;
        }
        private Int64 studentNumber;
        public Int64 StudentNumber { get { return studentNumber; } set { studentNumber = value; } }

        private String name;
        public String Name { get { return name; } set {name = value; } }

        private String classCode;
        public String ClassCode { get {return classCode; } set {classCode = value; } }

        ToOffset HoursToOffset = new ToOffset();
        Compensated CompensatedHours = new Compensated();
    }
}
