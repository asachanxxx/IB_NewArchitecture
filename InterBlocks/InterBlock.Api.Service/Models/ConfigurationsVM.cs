using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InterBlock.Api.Service.Models
{
    public class ConfigurationsVM
    {
        public static string CARD_SCHEMA_NAME { get; set; }
        public static int CONNECTION_QUEUE_SIZE { get; set; }
        public static string CUSTOMER_PRINT { get; set; }
        public static string CUSTOMER_REPRINT { get; set; }
        public static string DB_CATALOG_NAME { get; set; }
        public static string DB_DATABASE_NAME { get; set; }
        public static string DB_DBMS { get; set; }
        public static string DB_DSN { get; set; }
        public static string DB_FILE_NAME { get; set; }
        public static string DB_FILE_PATH { get; set; }
        public static string DB_HOST_IP { get; set; }
        public static string DB_HOST_PORT { get; set; }
        public static string DB_HOST_SERVICE_NAME { get; set; }
        public static string DB_SCHEMA_NAME { get; set; }
        public static string DB_USER_NAME { get; set; }
        public static string DB_USER_PASSWORD { get; set; }
        public static bool IGNORE_COLUMN_HEADER { get; set; }
        public static string LISTEN_IP { get; set; }
        public static int LISTEN_PORT { get; set; }
        public static string MERCHANT_PRINT { get; set; }
        public static string MERCHANT_REPRINT { get; set; }
        public static bool OTHER { get; set; }
        public static bool PCI_ENABLE { get; set; }
        public static bool PRODUCT { get; set; }
        public static bool SHOW_BACKGROUND_PROGRESS { get; set; }
        public static int SOCKET_READ_TIMEOUT { get; set; }
        public static bool START_SERVICE_AUTO { get; set; }
        public static string SVC_PRINT { get; set; }
        public static string SVC_REPRINT { get; set; }
    }
}