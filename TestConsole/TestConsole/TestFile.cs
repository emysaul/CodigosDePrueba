using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestWebServices;
using TestWebServices.Dtos;

namespace TestConsole
{
    public class TestFile
    {
        private static void MyMain()
        {
            var services = new List<ServiceDto>();
            services.Add(new ServiceDto()
            {
                NameService = "Suscription",
                UrlService = "http://soadevenv1:6010/services/billing/GetSubscriptionsBySubscriberNo",
                TemplateInput = GetFullFile("PAC\\subscriptionsPhoneInput"),
                TemplateOuput = GetFullFile("PAC\\subscriptionsPhoneOuput")
            });

            services.Add(new ServiceDto()
            {
                NameService = "Suscription",
                UrlService = "http://soadevenv1:6010/services/billing/GetSubscriptionsBySubscriberNo",
                TemplateInput = GetFullFile("PAC\\subscriptions PhoneInput"),
                TemplateOuput = GetFullFile("PAC\\subscriptionsPhoneOuput")
            });



            var result = new TestServices().GetTestServices(services);
        }

        public static string GetFullFile(string nameFile)
        {
            var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);

            string path = $"{directory}\\Templates\\{nameFile}.xml";

            return path;
        }


        public static IEnumerable<PermissionDto> GetMissingPermissions(IEnumerable<PermissionDto> sourceA, IEnumerable<PermissionDto> sourceB)
        {
            return sourceA.Where(e => !sourceB.Select(d => d.Key).Contains(e.Key));
        }

        public static IEnumerable<PermissionDto> GetPermissions()
        {
            var classPermission = typeof(Constants.Permission);
            var members = classPermission.GetNestedTypes(BindingFlags.Public);

            var permissionList = members.SelectMany(d => d.GetFields()).Select(e => new PermissionDto()
            {
                Key = e.Name,
                Value = e.GetValue(e).ToString()
            }).ToList();

            var missings = GetMissingPermissions(permissionList, permissionList.Take(permissionList.Count - 10));

            return permissionList;
        }
    }
}
