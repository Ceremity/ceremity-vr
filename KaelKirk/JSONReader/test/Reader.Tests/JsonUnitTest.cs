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

      string json = @"{
        'Song': {
          'Title': 'Capsize (feat. Emily Warren)',
          'Artist': 'FRENSHIP',
          'Album': 'A Beautiful Life Music',
          'Path': './NotTorrented/Music/Song.mp3',
          'Duration': '0001-01-01T00:00:00.0238000'
        },
        'BlockTiming': [
          '0001-01-01T00:00:00.0041500',
          '0001-01-01T00:00:00.0062000',
          '0001-01-01T00:00:00.0113000',
          '0001-01-01T00:00:00.0134000',
          '0001-01-01T00:00:00.0178000',
          '0001-01-01T00:00:00.0198000'
        ]
      }";

      Level deserialized = JsonConvert.DeserializeObject<Level>(json);

      Assert.Equal(one.Song.Title, deserialized.Song.Title);
      Assert.Equal(one.Song.Duration, deserialized.Song.Duration);
      Assert.Equal(one.BlockTiming[0], deserialized.BlockTiming[0]);
    }
  }
}
