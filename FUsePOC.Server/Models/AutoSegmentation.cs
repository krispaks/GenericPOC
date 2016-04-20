﻿using FusePOC.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUsePOC.Server.Models
{
	public class AutoSegmentation : ISegmentationData
	{
		public int SegmentationSpecificData2 { get; set; }

		public string SegmentationSpecificData1 { get; set; }

		public string AutoSegmentationData1 { get; set; }
		public int AutoSegmentationData2 { get; set; }

		public int AutoSegmentationData3 { get; set; }
	}
}
