using System.Collections.Generic;

namespace Flow.Launcher.Plugin.FlowVirtualBox
{
    public class VirtualBox : IPlugin
    {
        internal PluginInitContext Context;
        private const string Image = @"Images\virtualbox.png";
        private PluginInitContext _context;

        public void Init(PluginInitContext context)
        {
            _context = context;
        }

        public List<Result> Query(Query query)
        {
            return new List<Result>();
        }

        
    }
}