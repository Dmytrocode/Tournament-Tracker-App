﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess.TextConnector
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName) //PrizeModel.csv
        {
            // C:\data\TournamentTracker [ \ PrizeModel.csv ]
            return $"{ ConfigurationManager.AppSettings["filePath"] } \\{ fileName }";
        }

        public static List<string> LoadFile(this string file)
        {
            if(!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModel(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>;

            foreach(string line in lines)
            {

            }

            return List<PrizeModel>
        }
    }
}
