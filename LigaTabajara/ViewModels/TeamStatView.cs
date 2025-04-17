using LigaTabajara.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LigaTabajara.ViewModels
{
	public class TeamStatView
	{
        public Time Time { get; set; }
        public int Points { get; set; }
        public int GoalDifference { get; set; }
        public bool IsApto { get; set; }
        public int Games { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
    }
}