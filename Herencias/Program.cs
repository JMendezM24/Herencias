
using Herencias.ClaseHija;

Nintendo sw = new Nintendo();
sw.EsPortatil = true;
sw.AnioLanzamiento = 2017;
sw.Marca = "nintendo Switch";
string resultado = sw.MostrarDetallesNintendo();
Console.WriteLine(resultado);

PlayStation ps = new PlayStation();
ps.ModeloControlador = "Dual Sense";
ps.AnioLanzamiento = 2020;
ps.Marca = "Play Station 5";
string resultado2 = ps.MostrardetallesPS();
Console.WriteLine(resultado2);

Xbox xgp = new Xbox();
xgp.XboxGamePass = "Incluye GamePass";
xgp.AnioLanzamiento = 2005;
xgp.Marca = "Xbox 360";
string resultado3 = xgp.MostarDetallesXbox();
Console.WriteLine(resultado3);