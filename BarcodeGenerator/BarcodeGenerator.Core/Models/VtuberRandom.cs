using System;
using System.Collections.Generic;
using Prism.Mvvm;

namespace BarcodeGenerator.Core.Models
{
	public class VTuberRandom : BindableBase
	{
		private string name;
		public string Name
		{
			get => name;
			set => SetProperty(ref name, value);
		}

		private readonly List<string> nameList;

		public VTuberRandom()
		{
			nameList = new List<string>()
			{
				"九条林檎","九条棗","九条杏子","九条茘枝",
				"雨ヶ崎笑虹","都三代らみょん","三田そにあ","縁うか","ひなわんこ",
				"巻乃もなか","幸糖ミュウミュウ","青咲ローズ","泡沫調",
				"白乃クロミ","碧惺スキア","紫吹ふうか","菜花なな",
				"結目ユイ","水瀬しあ"
			};
		}

		public void RandomNameSet()
		{
			var seed = Environment.TickCount;
			var rand = new Random(seed);
			var no = rand.Next(0, nameList.Count);
			Name = nameList[no];
		}
	}
}