using PowerBIEmbedded_AppOwnsData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PowerBIEmbedded_AppOwnsData.Services
{
    public interface IEmbedService
    {
        EmbedConfig EmbedConfig { get; }

        Task<bool> EmbedReport(string userName, string roles);
        Task<bool> EmbedDashboard();
    }
}
