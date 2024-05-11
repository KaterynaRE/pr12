using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl3
{
	public class Songs
	{
		public string NameSong {  get; set; }
		public TimeSpan DurationSong {  get; set; }
		public string GenreSong {  get; set; }
		public Songs(string nameSong, TimeSpan durationSong, string genreSong) 
		{
			NameSong = nameSong;
			DurationSong = durationSong;
			GenreSong = genreSong;
		}
		public override string ToString()
		{
			return $"Name song: {NameSong}, Duration: {DurationSong}, Genre: {GenreSong}";
		}

	}
}
