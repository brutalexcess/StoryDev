using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;
using System.Web.Helpers;
using System.Diagnostics;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace StoryDev
{
    public class Project
    {
        public List<Passage> passages;
        public List<GameEvent> events;
        public string path;
        public string file;
        public int pid;
        public int eid;

        public static string FLASH = "flash";
        //public static string WINDOWS = "windows";
        //public static string MAC = "mac";
        //public static string LINUX = "linux";

        public Project(string file = "")
        {
            passages = new List<Passage>();
            events = new List<GameEvent>();
            if (file != "")
            {
                this.file = file;
                path = file.Substring(0, file.LastIndexOf("\\"));
                CopyDir.Copy("engine/", path + "/engine/");
            }
        }

        public void AddPassage(Passage p)
        {
            p.id = pid;
            pid++;
            var amount = passages.Count;
            if (amount == 0)
                passages.Add(p);
            else
            {
                foreach (Passage passage in passages)
                {
                    if (passage.id == p.id)
                        return;
                    else if (amount == 1)
                    {
                        passages.Add(p);
                        break;
                    }
                    amount--;
                }
            }
        }

        public void RemovePassage(int id)
        {
            foreach (Passage p in passages)
            {
                if (p.id == id)
                {
                    passages.Remove(p);
                    break;
                }
            }
        }

        public void AddGameEvent(GameEvent ge)
        {
            ge.id = eid;
            eid++;
            var amount = events.Count;
            if (amount == 0)
                events.Add(ge);
            else
            {
                foreach (GameEvent e in events)
                {
                    if (ge.id == e.id)
                        return;
                    else if (amount == 1)
                    {
                        events.Add(ge);
                        break;
                    }
                    amount--;
                }
            }
        }

        public void RemoveGameEvent(int id)
        {
            foreach (GameEvent ge in events)
            {
                if (ge.id == id)
                {
                    events.Remove(ge);
                    break;
                }
            }
        }

        public void ExportJson()
        {
            var jsonPassages = Json.Encode(passages);
            jsonPassages = jsonPassages.Replace("\\u0027", "'");
            jsonPassages = jsonPassages.Replace("\\r", "");
            jsonPassages = jsonPassages.Replace("\\\\", "\\");
            var jsonEvents = Json.Encode(events);
            jsonEvents = jsonEvents.Replace("\\u0027", "'");
            jsonEvents = jsonEvents.Replace("\\r", "");
            jsonEvents = jsonEvents.Replace("\\\\", "\\");


            File.WriteAllText(path + "/engine/Assets/info/passages.json", jsonPassages);
            File.WriteAllText(path + "/engine/Assets/info/events.json", jsonEvents);
        }

        public void BuildAndTest(string target)
        {
            try
            {
                ExportJson();
                var cmd = Process.Start("cmd.exe", "/c haxelib run openfl build \"" + path + "\\engine\\project.xml\" " + target);
                
                cmd.WaitForExit();
                if (target == FLASH)
                    Process.Start(path + "/engine/bin/flash/bin/StoryDev.swf");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Save(string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.Create))
            {
                using (GZipStream zip = new GZipStream(fs, CompressionMode.Compress))
                {
                    using (BinaryWriter bw = new BinaryWriter(zip))
                    {
                        bw.Write(passages.Count);
                        foreach (Passage p in passages)
                        {
                            bw.Write(p.id);
                            bw.Write(p.title);
                            bw.Write(p.htmlText);
                            bw.Write(p.text);
                        }
                        bw.Write(events.Count);
                        foreach (GameEvent e in events)
                        {
                            bw.Write(e.id);
                            bw.Write(e.title);
                            bw.Write(e.code);
                        }

                        bw.Write(pid);
                        bw.Write(eid);
                        bw.Close();

                        MessageBox.Show("Save successful.");
                    }
                }
            }
        }

        public void Load(string file)
        {
            this.file = file;
            path = file.Substring(0, file.LastIndexOf("\\"));
            using (FileStream fs = new FileStream(file, FileMode.Open))
            {
                using (GZipStream zip = new GZipStream(fs, CompressionMode.Decompress))
                {
                    using (BinaryReader br = new BinaryReader(zip))
                    {
                        Reset();
                        var count = br.ReadInt32();
                        for (var i = 0; i < count; i++)
                        {
                            var p = new Passage();
                            p.id = br.ReadInt32();
                            p.title = br.ReadString();
                            p.htmlText = br.ReadString();
                            p.text = br.ReadString();
                            passages.Add(p);
                        }
                        count = br.ReadInt32();
                        for (var i = 0; i < count; i++)
                        {
                            var e = new GameEvent();
                            e.id = br.ReadInt32();
                            e.title = br.ReadString();
                            e.code = br.ReadString();
                            events.Add(e);
                        }

                        pid = br.ReadInt32();
                        eid = br.ReadInt32();

                        br.Close();

                        MessageBox.Show("Load successful.");
                    }
                }
            }
        }

        private void Reset()
        {
            passages = new List<Passage>();
            events = new List<GameEvent>();
            pid = 0;
            eid = 0;
        }

    }
}
