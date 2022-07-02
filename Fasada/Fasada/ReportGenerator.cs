﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasada
{
    public class ReportGenerator
    {
        public void GenerateReport(IEnumerable<string> qualityScanErrors, IEnumerable<string> securityScanErrors, IEnumerable<string> dependencyScanErrors)
        {
            Console.WriteLine("Quality Scan Errors:");
            Console.WriteLine(string.Join(", ", qualityScanErrors));

            Console.WriteLine("securityScanErrors:");
            Console.WriteLine(string.Join(", ", securityScanErrors));

            Console.WriteLine("dependencyScanErrors:");
            Console.WriteLine(string.Join(", ", dependencyScanErrors));

        }
    }
}