using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using WeeeTrackerAPI.Models;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WeeeTrackerAPI.Common
{
    public class JWTHelper
    {
        public static string GetToken(
            IConfiguration config,
            ContactosDireccionTercero usuario,
            object tercero,
            object centros,
            object perfiles,
            object residuosEspecificos,
            object marcas,
            object resp
            )
        {
            //----------------------------------------------------------------------------------------------------------------------------
            // Generación del Token JWT.

            var _context = new GVRBD3Context();

            var direcciones = JsonConvert.SerializeObject(
                usuario.SidTerceroNavigation
                    ,Formatting.None,
                    new JsonSerializerSettings(){ ReferenceLoopHandling = ReferenceLoopHandling.Ignore});

            var tokenHandler = new JwtSecurityTokenHandler();
            // var key = Encoding.ASCII.GetBytes(config["Jwt:Key"].PadRight(16, '0'));
            var claims = new Claim[]
            {
                new Claim(Claims.Id.ToString(), ((long)usuario.PidContactoDireccionTercero).ToString()),
                new Claim(Claims.Login.ToString(), usuario.Email),
                new Claim(Claims.Tercero.ToString(), JsonConvert.SerializeObject(tercero)),
                new Claim(Claims.Resps.ToString(), JsonConvert.SerializeObject(resp)),
                new Claim(Claims.Direcciones.ToString(), direcciones),
                // new Claim(Claims.TipoTercero.ToString(), ((long)tipo.SidTipoTercero).ToString()),
                new Claim(Claims.Estado.ToString(), ((long)usuario.Estado).ToString()),
                new Claim(Claims.Centros.ToString(), JsonConvert.SerializeObject(centros)),
                new Claim(Claims.Perfiles.ToString(), JsonConvert.SerializeObject(perfiles)),
                new Claim(Claims.Residuos.ToString(), JsonConvert.SerializeObject(residuosEspecificos)),
                new Claim(Claims.Marcas.ToString(), JsonConvert.SerializeObject(marcas))
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"].PadRight(16, '0')));

            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                config["Jwt:Issuer"],
                config["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToDouble(config["Jwt:ExpireMin"])),
                signingCredentials: signIn);
            
            // var tokenDescriptor = new SecurityTokenDescriptor
            // {
            //     Subject = new ClaimsIdentity(new Claim[]
            //     {
            //             new Claim(Claims.Id.ToString(), ((long)usuario.Id).ToString()),
            //             new Claim(Claims.Login.ToString(), usuario.Usuario),
            //             new Claim(Claims.Tercero.ToString(), JsonConvert.SerializeObject(tercero)),
            //             new Claim(Claims.TipoTercero.ToString(), ((long)usuario.SidTipoTercero).ToString()),
            //             new Claim(Claims.Estado.ToString(), ((long)usuario.Estado).ToString()),
            //             new Claim(Claims.Centros.ToString(), JsonConvert.SerializeObject(centros)),
            //             new Claim(Claims.Perfiles.ToString(), JsonConvert.SerializeObject(perfiles)),
            //             new Claim(Claims.Residuos.ToString(), JsonConvert.SerializeObject(residuosEspecificos)),
            //             new Claim(Claims.Marcas.ToString(), JsonConvert.SerializeObject(marcas))
            //     }),
            //     Issuer = config["Jwt:Issuer"],
            //     Audience = config["Jwt:Audience"],
            //     Expires = DateTime.UtcNow.AddMinutes(Convert.ToDouble(config["Jwt:ExpireMin"])),
            //     SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            // };

            // var token = tokenHandler.CreateToken(tokenDescriptor);

            // return tokenHandler.WriteToken(token);

            return new JwtSecurityTokenHandler().WriteToken(token);

            //----------------------------------------------------------------------------------------------------------------------------
        }

        public static Claim GetClaim(IEnumerable<Claim> claims, string nombre)
        {
            Claim claim = claims.FirstOrDefault(c => c.Type == nombre);
            return claim;
        }
    }
}
