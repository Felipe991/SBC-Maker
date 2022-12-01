using Newtonsoft.Json;
using SBC_Maker.Logica.Conjuntos_Difusos;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace SBC_Maker.Logica
{
    public class FuncionPertenenciaJsonConverter : System.Text.Json.Serialization.JsonConverter<FuncionPertenencia>
    {
        enum TypeDiscriminator
        {
            FuncionTriangular = 1,
            FuncionTrapezoidal = 2,
            FuncionGaussiana = 3
        }

        public override bool CanConvert(Type typeToConvert) =>
            typeof(FuncionPertenencia).IsAssignableFrom(typeToConvert);

        public override FuncionPertenencia Read(
            ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
            {
                throw new System.Text.Json.JsonException();
            }

            reader.Read();
            if (reader.TokenType != JsonTokenType.PropertyName)
            {
                throw new System.Text.Json.JsonException();
            }

            string? propertyName = reader.GetString();
            if (propertyName != "TypeDiscriminator")
            {
                throw new System.Text.Json.JsonException();
            }

            reader.Read();
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new System.Text.Json.JsonException();
            }

            TypeDiscriminator typeDiscriminator = (TypeDiscriminator)reader.GetInt32();
            FuncionPertenencia funcionPertenencia = typeDiscriminator switch
            {
                TypeDiscriminator.FuncionTriangular => new FuncionTriangular(),
                TypeDiscriminator.FuncionTrapezoidal => new FuncionTrapezoidal(),
                TypeDiscriminator.FuncionGaussiana => new FuncionGaussiana(),
                _ => throw new System.Text.Json.JsonException()
            };

            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndObject)
                {
                    return funcionPertenencia;
                }

                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    propertyName = reader.GetString();
                    reader.Read();
                    switch (propertyName)
                    {
                        case "Nombre":
                            string nombre = reader.GetString();
                            funcionPertenencia.Nombre = nombre;
                            break;
                        case "LimiteIzquierdo":
                            double limiteIzquierdo = reader.GetDouble();
                            ((FuncionTriangular)funcionPertenencia).limiteIzquierdo = limiteIzquierdo;
                            break;
                        case "Centro":
                            double centro = reader.GetDouble();
                            ((FuncionTriangular)funcionPertenencia).centro = centro;
                            break;
                        case "LimiteDerecho":
                            double limiteDerecho = reader.GetDouble();
                            ((FuncionTriangular)funcionPertenencia).limiteDerecho = limiteDerecho;
                            break;
                        case "LimIzquierdo":
                            double limIzquierdo = reader.GetDouble();
                            ((FuncionTrapezoidal)funcionPertenencia).limIzquierdo = limIzquierdo;
                            break;
                        case "CentroIzq":
                            double centroIzq = reader.GetDouble();
                            ((FuncionTrapezoidal)funcionPertenencia).centroIzq = centroIzq;
                            break;
                        case "CentroDer":
                            double centroDer = reader.GetDouble();
                            ((FuncionTrapezoidal)funcionPertenencia).centroDer = centroDer;
                            break;
                        case "LimDerecho":
                            double limDerecho = reader.GetDouble();
                            ((FuncionTrapezoidal)funcionPertenencia).limDerecho = limDerecho;
                            break;
                        case "CentroG":
                            double centroG = reader.GetDouble();
                            ((FuncionGaussiana)funcionPertenencia).centroG = centroG;
                            break;
                        case "DesviacionEstandar":
                            double desviacionEstandar = reader.GetDouble();
                            ((FuncionGaussiana)funcionPertenencia).DesviacionEstandar = desviacionEstandar;
                            break;
                    }
                }
            }

            throw new System.Text.Json.JsonException();
        }

        public override void Write(
            Utf8JsonWriter writer, FuncionPertenencia funcionPertenencia, JsonSerializerOptions options)
        {
            writer.WriteStartObject();
            
            if (funcionPertenencia is FuncionTriangular funcionTriangular)
            {
                writer.WriteNumber("TypeDiscriminator", (int)TypeDiscriminator.FuncionTriangular);
                writer.WriteNumber("LimiteIzquierdo", funcionTriangular.LimiteIzquierdo);
                writer.WriteNumber("Centro", funcionTriangular.Centro);
                writer.WriteNumber("LimiteDerecho", funcionTriangular.LimiteDerecho);
            }
            else if (funcionPertenencia is FuncionTrapezoidal funcionTrapezoidal)
            {
                writer.WriteNumber("TypeDiscriminator", (int)TypeDiscriminator.FuncionTrapezoidal);
                writer.WriteNumber("LimIzquierdo", funcionTrapezoidal.limIzquierdo);
                writer.WriteNumber("CentroIzq", funcionTrapezoidal.CentroIzq);
                writer.WriteNumber("CentroDer", funcionTrapezoidal.CentroDer);
                writer.WriteNumber("LimDerecho", funcionTrapezoidal.limDerecho);
            }
            else if (funcionPertenencia is FuncionGaussiana funcionGaussiana)
            {
                writer.WriteNumber("TypeDiscriminator", (int)TypeDiscriminator.FuncionGaussiana);
                writer.WriteNumber("CentroG", funcionGaussiana.CentroG);
                writer.WriteNumber("DesviacionEstandar", funcionGaussiana.DesviacionEstandar);
            }

            writer.WriteString("Name", funcionPertenencia.Nombre);
            writer.WriteEndObject();
        }
    }
}
