using MusicPlayer;
using System.Collections.Generic;
using System.IO;
using System.Xml;

public static class PlaylistManager
{
    private static string PlaylistXmlPath = @".\playlists.xml";

    public static List<Playlist> LoadPlaylists()
    {
        List<Playlist> playlists = new List<Playlist>();
        if (!File.Exists(PlaylistXmlPath))
            return playlists;

        XmlDocument doc = new XmlDocument();
        doc.Load(PlaylistXmlPath);

        foreach (XmlNode playlistNode in doc.SelectNodes("//Playlist"))
        {
            var playlist = new Playlist
            {
                Name = playlistNode.Attributes["Name"]?.Value
            };

            foreach (XmlNode songNode in playlistNode.SelectNodes("Song"))
            {
                playlist.Songs.Add(songNode.InnerText);
            }

            playlists.Add(playlist);
        }

        return playlists;
    }

    public static void SavePlaylists(List<Playlist> playlists)
    {
        XmlDocument doc = new XmlDocument();
        XmlElement root = doc.CreateElement("Playlists");
        doc.AppendChild(root);

        foreach (var playlist in playlists)
        {
            XmlElement playlistElement = doc.CreateElement("Playlist");
            playlistElement.SetAttribute("Name", playlist.Name);

            foreach (var songPath in playlist.Songs)
            {
                XmlElement songElement = doc.CreateElement("Song");
                songElement.InnerText = songPath;
                playlistElement.AppendChild(songElement);
            }

            root.AppendChild(playlistElement);
        }

        doc.Save(PlaylistXmlPath);
    }
}
