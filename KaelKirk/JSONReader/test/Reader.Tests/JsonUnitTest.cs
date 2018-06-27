using System;
using Xunit;
using Reader.ClassLib;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Reader.Tests {
  public class JsonUnitTest {
      
    [Fact]
    public void DeserializeLevelTest() {

      Level one = new Level();

      one.Song = new Song(
        "Capsize (feat. Emily Warren)",
        "FRENSHIP",
        "A Beautiful Life Music",
        "./NotTorrented/Music/Song.mp3",
        new DateTime(238000)
      );

      one.BlockTiming = new List<DateTime>() {
        new DateTime(41500),
        new DateTime(62000),
        new DateTime(113000),
        new DateTime(134000),
        new DateTime(178000),
        new DateTime(198000)
      };

      // StreamReader r = new StreamReader("file.json");
      // string json = r.ReadToEnd();
      string json = @"{
        'Song': {
          'Title': 'Capsize (feat. Emily Warren)',
          'Artist': 'FRENSHIP',
          'Album': 'A Beautiful Life Music',
          'Path': './NotTorrented/Music/Song.mp3',
          'Duration': 238000
        },
        'BlockTiming': [
          41500,
          62000,
          113000,
          134000,
          178000,
          198000
        ]
      }";

      Level deserialized = JsonConvert.DeserializeObject<Level>(json);

      Assert.Equal(one.Song.Title, deserialized.Song.Title);
      Assert.Equal(one.Song.Duration, deserialized.Song.Duration);
      Assert.Equal(one.BlockTiming[0], deserialized.BlockTiming[0]);
    }
  }
}
