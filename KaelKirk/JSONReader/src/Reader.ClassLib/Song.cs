using System;
using System.IO;

namespace Reader.ClassLib {
    
  public class Song {

    public string Title;
    public string Artist;
    public string Album;
    public string Path;
    public DateTime Duration;

    public Song(string Title, string Artist, string Album, string Path, DateTime Duration) {
      this.Title = Title;
      this.Artist = Artist;
      this.Album = Album;
      this.Path = Path;
      this.Duration = Duration;
    }
  }
}