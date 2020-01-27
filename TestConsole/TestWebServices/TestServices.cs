using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using TestWebServices.Dtos;
using TestWebServices.ExtendMethods;
using TestWebServices.Utils;

namespace TestWebServices
{

    public class TestServices
    {
        FileProcesessor fileProcesessor;
        public TestServices()
        {
            fileProcesessor = new FileProcesessor();
        }

        public IEnumerable<ServicesTestDto> GetTestServices(IEnumerable<ServiceDto> services)
        {
            var servicesTested = new List<ServicesTestDto>();

            foreach (var service in services)
            {
                try
                {
                    string input = fileProcesessor.ReadAllTextFromFile(service.TemplateInput);
                    string ouput = fileProcesessor.ReadAllTextFromFile(service.TemplateOuput);

                    var response = CallWebRequestGetResponse(input, service.UrlService);

                    AddServicesTest(servicesTested, service, ouput, response);
                }
                catch (Exception ex)
                {
                    servicesTested.Add(new ServicesTestDto()
                    {
                        Name = service.NameService,
                        MessageError = ex.Message
                    });
                }
            }

            return servicesTested;
        }

        private static void AddServicesTest(List<ServicesTestDto> servicesTested, ServiceDto service, string ouput, string response)
        {
            if (Regex.Replace(response, @"\s+", "").MatchTest(Regex.Replace(ouput, @"\s+", ""), 0.7))
                servicesTested.Add(new ServicesTestDto()
                {
                    IsSuccess = true,
                    Name = service.NameService
                });
            else
                servicesTested.Add(new ServicesTestDto()
                {
                    IsSuccess = false,
                    Name = service.NameService,
                    MessageError = "Servicio no cumple con el xml experado."
                });
        }

        public virtual string CallWebRequestGetResponse(string xmlContent, string requestUrl)
        {

            var doc = XmlProcessator.GetXmlDocument(xmlContent);

            try
            {
                return HttpProcessor.CallWebService(requestUrl, doc.OuterXml, "application/xml");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
