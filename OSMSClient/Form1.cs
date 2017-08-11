using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CCPROOSMSCLIENTLib;
//using Memcached.ClientLibrary;
using System.Threading;
using Newtonsoft.Json;
using Enyim.Caching;
using Enyim.Caching.Memcached;
using Enyim.Caching.Configuration;
using System.Net;
using System.Linq;
using Couchbase;

using Couchbase.Core;
using Couchbase.Configuration.Client;

namespace OSMSClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OsmsClientGlobalClass OSMC = new OsmsClientGlobalClass();
            OSMC.SetComponentName("ABC");
           
        }
        public MemcachedClient MClient;

        private void button3_Click(object sender, EventArgs e)
        {
           
            /*
            //DbSet<crm_aspect_monitor_aod> set = t.Set<crm_aspect_monitor_aod>();

          //  List<crm_aspect_monitor_aod> userlist = t.crm_aspect_monitor_aod.sql("select * from [UserInfoes]").ToList();  

            crm_aspect_monitor_aod aoddata = new crm_aspect_monitor_aod();
            aoddata.abandonbydialer24hour = "aa";
            string str = JsonConvert.SerializeObject(aoddata);
             * */

        }

        private void button4_Click(object sender, EventArgs e)
        {
            crm_aspect_monitor_aod crm = new crm_aspect_monitor_aod();

            crm_aspect_monitor_aod aoddata = new crm_aspect_monitor_aod();
            

            string tmp = JsonConvert.SerializeObject(aoddata);
           // string tmp = "abc";
            string str ="{"+string.Format("\"aod_12\":\"{0}\"", tmp) + "}";

            //string str = string.Format("{0}", tmp);
            Console.WriteLine(str);
        }
        public MemcachedClient mc;
       
        private void button5_Click(object sender, EventArgs e)
        {
            using (var ctx = new testEntities_acd())
            {
                {

                    try
                    {
            
                        var users = from ex in ctx.crm_aspect_monitor_acd2 select ex;
                        foreach (var c in users)
                        {

                            acd acdaspect = utils.TransToAcd(c);
                            string jsonkey = string.Format("acd_{0}", c.serviceId);
                            string jsonvalue = JsonConvert.SerializeObject(acdaspect);
                            Console.WriteLine(jsonvalue);

                            if (mc.Get(jsonkey) != null)
                            {

                                bool b = mc.Store(StoreMode.Replace, jsonkey, jsonvalue);

                                Console.WriteLine(string.Format("replace key {0}============{1}", jsonkey, b));
                            }
                            else
                            {

                                bool b = mc.Store(StoreMode.Add, jsonkey, jsonvalue);

                                Console.WriteLine(string.Format("add key {0}============{1}", jsonkey, b));
                            }

                        }

                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }

           
           
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

            MemcachedClientConfiguration mcon = new MemcachedClientConfiguration();
            
            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("192.168.1.200"), 11211);  
            // 配置文件 - ip  
            mcon.Servers.Add(ipEndPoint);

            mcon.Protocol = MemcachedProtocol.Binary;
            mcon.SocketPool.MinPoolSize = 5;
            mcon.SocketPool.MaxPoolSize = 200; 
            

            mc = new MemcachedClient(mcon);
           
        }

        
        private void button4_Click_1(object sender, EventArgs e)
        {
          
            using (var ctx = new testEntities_crm_aspect_monitor_aod())
            {
                {
                 
                    try
                    {
                        
                        var users = from ex in ctx.crm_aspect_monitor_aod2 select ex;
                        foreach (var c in users)
                        {

                            crm_aspect_monitor_aod aodaspect = utils.TransToAod(c);
                            string jsonkey = string.Format("aod_{0}", c.serviceid);
                            string jsonvalue = JsonConvert.SerializeObject(aodaspect);
                            Console.WriteLine(jsonvalue);
                            
                          

                            if (mc.Get(jsonkey) != null)
                            {
                                
                                bool b =mc.Store(StoreMode.Replace, jsonkey, jsonvalue);

                                Console.WriteLine(string.Format("replace key {0}============{1}",jsonkey,b));
                            }
                            else
                            {
                                
                                bool b =mc.Store(StoreMode.Add, jsonkey, jsonvalue);

                                Console.WriteLine(string.Format("add key {0}============{1}", jsonkey, b));
                            }
                            break;
                        }
                        

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    
                }
            }
        
        }

        private void button7_Click(object sender, EventArgs e)
        {

            string key = textBox1.Text;

            Console.WriteLine("value: " + mc.Get(key));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var ctx = new testEntities_agentpri())
            {
                {

                    try
                    {

                        var users = from ex in ctx.crm_aspect_monitor_agent2 select ex;
                        foreach (var c in users)
                        {

                            agent agentaspect = utils.TransToAgent(c);
                            string jsonkey = string.Format("agent_{0}_{1}", c.userId,c.serviceId);
                            string jsonvalue = JsonConvert.SerializeObject(agentaspect);
                            Console.WriteLine(jsonvalue);

                            if (mc.Get(jsonkey) != null)
                            {

                                bool b = mc.Store(StoreMode.Replace, jsonkey, jsonvalue);

                                Console.WriteLine(string.Format("replace key {0}============{1}", jsonkey, b));
                            }
                            else
                            {

                                bool b = mc.Store(StoreMode.Add, jsonkey, jsonvalue);

                                Console.WriteLine(string.Format("add key {0}============{1}", jsonkey, b));
                            }

                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            using (var ctx = new testEntities_wrokgroup())
            {
                    try
                    {

                        
                        var users = from ex in ctx.crm_aspect_monitor_workgroup2 select ex;
                        foreach (var c in users)
                        {

                            wrokgroup wrokgroupaspect = utils.TransToWrokgroup(c);
                            string jsonkey = string.Format("workgroup_{0}", c.workgroupId);
                            string jsonvalue = JsonConvert.SerializeObject(wrokgroupaspect);
                            Console.WriteLine(jsonvalue);

                            if (mc.Get(jsonkey) != null)
                            {

                                bool b = mc.Store(StoreMode.Replace, jsonkey, jsonvalue);

                                Console.WriteLine(string.Format("replace key {0}============{1}", jsonkey, b));
                            }
                            else
                            {

                                bool b = mc.Store(StoreMode.Add, jsonkey, jsonvalue);

                                Console.WriteLine(string.Format("add key {0}============{1}", jsonkey, b));
                            }

                        }
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string jsonkey = string.Format("aod_1");
            
            string jsonvalue = "{\"service\":\"1\"}";

            if (mc.Get(jsonkey) != null)
            {

                bool b = mc.Store(StoreMode.Replace, jsonkey, jsonvalue);

                Console.WriteLine(string.Format("replace key {0}============{1}", jsonkey, b));
            }
            else
            {

                bool b = mc.Store(StoreMode.Add, jsonkey, jsonvalue);

                Console.WriteLine(string.Format("add key {0}============{1}", jsonkey, b));
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            using (var ctx = new testEntities_table())
            {
                try
                {
                    var users = from ex in ctx.crm_aspect_monitor_table2 select ex;
                    foreach (var c in users)
                    {

                        table tableaspect = utils.TransTotable(c);
                        string jsonkey = string.Format("table_{0}", c.tableId);
                        string jsonvalue = JsonConvert.SerializeObject(tableaspect);
                        Console.WriteLine(jsonvalue);

                        if (mc.Get(jsonkey) != null)
                        {

                            bool b = mc.Store(StoreMode.Replace, jsonkey, jsonvalue);

                            Console.WriteLine(string.Format("replace key {0}============{1}", jsonkey, b));
                        }
                        else
                        {

                            bool b = mc.Store(StoreMode.Add, jsonkey, jsonvalue);

                            Console.WriteLine(string.Format("add key {0}============{1}", jsonkey, b));
                        }

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            using (var ctx = new testEntities_resourcegroup())
            {
                try
                {
                    var users = from ex in ctx.crm_aspect_monitor_rgstats2 select ex;
                    foreach (var c in users)
                    {
                        resourcegroup resourcegroupaspect = utils.TransToResourceGroup(c);
                        string jsonkey = string.Format("resourcegroup_{0}", c.resourceGroupId);
                        string jsonvalue = JsonConvert.SerializeObject(resourcegroupaspect);
                        Console.WriteLine(jsonvalue);

                        if (mc.Get(jsonkey) != null)
                        {

                            bool b = mc.Store(StoreMode.Replace, jsonkey, jsonvalue);

                            Console.WriteLine(string.Format("replace key {0}============{1}", jsonkey, b));
                        }
                        else
                        {

                            bool b = mc.Store(StoreMode.Add, jsonkey, jsonvalue);

                            Console.WriteLine(string.Format("add key {0}============{1}", jsonkey, b));
                        }

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

       


        private void button11_Click(object sender, EventArgs e)
        {
           
          //  CouchbaseClient client = new CouchbaseClient(cbcc);

            using (var bucket = Cluster.OpenBucket("192.168.1.200"))
            {
                var document = new Document<dynamic>
                {
                    Id = "Hello",
                    Content = new
                    {
                        name = "Couchbase"
                    }
                };

                var upsert = bucket.Upsert(document);
                if (upsert.Success)
                {
                    var get = bucket.GetDocument<dynamic>(document.Id);
                    document = get.Document;
                   var msg = string.Format("{0} {1}!", document.Id, document.Content.name);
                    Console.WriteLine(msg);
                }
                Console.Read();

            }

        }

        public Cluster Cluster;

        private void button12_Click(object sender, EventArgs e)
        {
            ClientConfiguration ction = new ClientConfiguration();
            ction.ApiPort(8901);
            ction.
            Cluster = new Cluster();
        }
    }
}
