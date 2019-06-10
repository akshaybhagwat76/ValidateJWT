using System;
using System.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace ValidateJWT
{
    class Program
    {
        static void Main(string[] args)
        {
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Il84cXZrbUVpazQtejlvU2xFSUJGQnNDQlN6byJ9.eyJ1bmlxdWVfbmFtZSI6InBydWViYTExQHZheW9vLmNvbSIsImdpdmVuX25hbWUiOiIiLCJmYW1pbHlfbmFtZSI6IiIsImVtYWlsIjoicHJ1ZWJhMTFAdmF5b28uY29tIiwibmFtZWlkIjoiajliZ09vV24iLCJvdXRzZXRhOmFjY291bnRVaWQiOiJ4RTlMWW5XdyIsIm91dHNldGE6YWNjb3VudENsaWVudElkZW50aWZpZXIiOiIzNzM0OSIsIm91dHNldGE6aXNQcmltYXJ5IjoiMSIsIm91dHNldGE6c3Vic2NyaXB0aW9uVWlkIjoiS2FXeDNiOVYiLCJvdXRzZXRhOnBsYW5VaWQiOiJwTDlQclBtSiIsImF1ZCI6InZheW9vLm91dHNldGEuY29tIiwiaXNzIjoidmF5b28ub3V0c2V0YS5jb20iLCJleHAiOjE1NjAwNDQ3MTcsIm5iZiI6MTU2MDAxNTkxN30.ZrX6DhufyZZYmmQYVAQOOpmsmaqdzG5W1pjS2MSHpLztHHczpriXSYDYttPR9_TRPiGc-nNuvEjiOWvF9lqstILhbR3sprNUPqFxBH89whuxYPXRCOGp0pSckZoLpNJ7IfuQ8uQGeEN_e5llXRO_KCHHJCQdDUwpdMegGmF-zWau2Kz-3iQau5a4VlRdgMK8RoyR75Rg0VlClaPNjPmN1lkS6p3bKADJweSZgx60DkLeLu-w88pTtwq3JPy10jXK_TuCK15SZDWtQ_ErIT5_RC15olIw3WXvec3GZnw_1bXkFOzaj86pWaAJdaBNMgmlvhXYZEm6xZeO6RQb_QRh6g";
            var jwtHandler = new JwtHandler();
            var publicKey = ConfigurationManager.AppSettings["PublicKey"].ToString();           
            var output = jwtHandler.ValidateToken(token, publicKey);
        }
    }
}
