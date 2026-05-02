using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Nodes;
using System.Text.Json;
using static Modul9_103022400002.BankTransferConfig;

namespace Modul9_103022400002
{
    internal class BankTransferConfig
    {
        public  Config config;
        private const string filePath = "bank_transfer_config.json";

        public BankTransferConfig() { }
        public void ReadConfigFile() {
            ConfigJson data = JsonSerealizer.Deserialise(filePath);
        }
        public void WriteConfigFile() { 
            var option = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(json, option);
        }
        public void setDefault() { 
        Config ci = new Config();
            
        }
    }
    internal class Config
    {
        public Config() { }
        public Config(string lang, transfer transfer, List<string> methods, confirmation confirmations)
        {
            this.lang = lang;
            Transfer = transfer;
            this.methods = methods;
            this.confirmations = confirmations;
        }

        public string lang { get; set; }
        public transfer Transfer { get; set; }
        public List<string> methods { get; set; }
        public  confirmation confirmations { get; set; }
    }
    internal class transfer
    {
        public transfer() { }
        public transfer(int threshold, int low_fee, int high_free)
        {
            this.threshold = threshold;
            this.low_fee = low_fee;
            this.high_fee = high_free;
        }
        public int threshold { get; set; }
        public int low_fee { get; set; }
        public int high_fee { get; set; }
    }

    internal class confirmation
    {
        public confirmation() { }
        public confirmation(string en, string id)
        {
            this.en = en;
            this.id = id;
        }

        public string en { get; set; }
        public string id { get; set; }
    }
}
