using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using Testsign.Models;

namespace Testsign.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string filePath = @"C:\Users\Johan\OneDrive\Skrivebord\TeDo\Tedo---Web\TeDoWeb\Testsign\CSharp+Book+2019+Refresh.pdf";
            X509Certificate2 certificate = new X509Certificate2("cert.pfx", "12345");
            RSA publickey = certificate.GetRSAPublicKey();
            RSA privatekey = certificate.GetRSAPrivateKey();
            byte[] dataToSign;
            using(StreamReader reader = new StreamReader(filePath))
            {
                using(MemoryStream ms = new MemoryStream())
                {
                    reader.BaseStream.CopyTo(ms);
                    dataToSign = ms.ToArray();
                }
            }

            using (RSA rsa = privatekey)
            {
                byte[] signature = rsa.SignData(dataToSign, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);
                
                System.IO.File.WriteAllBytes("test.pdf", signature);
                System.IO.File.WriteAllBytes("test2.pdf", dataToSign);
                using (RSA rsa2 = publickey)
                {
                    // Compute the hash of the original document
                    byte[] originalHash = SHA256.Create().ComputeHash(dataToSign);
                    // Verify the digital signature
                    bool signatureValid = rsa2.VerifyData(dataToSign, signature, HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1);

                    if (signatureValid)
                    {
                        Console.WriteLine("Signature is valid. The document has not been tampered with.");
                    }
                    else
                    {
                        Console.WriteLine("Signature is invalid. The document may have been tampered with.");
                    }
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}