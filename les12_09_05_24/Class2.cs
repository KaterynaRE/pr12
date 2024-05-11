using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cl3;

namespace cl2
{
	public class MusicAlbum
	{
		public List<Songs> songs;
		public string NameAlbum {  get; set; }
	    public string ArtistName {  get; set; }
		public DateTime GraduationYear { get; set; }
		public TimeSpan Duration { get; set; }
		public string RecordingStudio {  get; set; }

		public MusicAlbum()	{}
		public MusicAlbum(string nameAL, string artN, DateTime gradYear, TimeSpan duration, string recordS)
		{
			NameAlbum = nameAL;
			ArtistName = artN;
			GraduationYear = gradYear;
			Duration = duration;
			RecordingStudio = recordS;
			songs = new List<Songs>();
		}
		
		public void AddSong(Songs songsP)
		{
           songs.Add(songsP);
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"\nName album: {NameAlbum}, \nArtist name: {ArtistName},\nGraduation Year:" +
				$" {GraduationYear},\nDuration: {Duration},\nRecording Studio: {RecordingStudio}");
			if (songs != null && songs.Any())
			{
				sb.AppendLine("Songs:");
				foreach (var song in songs)
				{
					sb.AppendLine(song.ToString());
				}
			}
			return sb.ToString();
		}

	}
}
