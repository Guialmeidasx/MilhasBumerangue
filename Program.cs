double PercentualDeBonus, PercentualDeRetorno;
double PontosATransferir, PontosAReduzir, PontosAAcrescentar;
 
Console.Clear();
Console.WriteLine("--milhas bumerangue---\n");
 
Console.Write("Percentual de Bônus.....: ");
PercentualDeBonus = Convert.ToDouble(Console.ReadLine());
 
Console.Write("Percentual de retorno.....: ");
PercentualDeRetorno = Convert.ToDouble(Console.ReadLine());
 
Console.Write(".....: ");
PontosATransferir = Convert.ToDouble(Console.ReadLine());
 
 PontosAReduzir= PontosATransferir - (PontosATransferir * PercentualDeRetorno) / 100;
 PontosAAcrescentar = PontosATransferir + (PontosATransferir * PercentualDeRetorno) / 100;
 
Console.WriteLine();
Console.WriteLine($"Pontos a reduzir na origem........: {PontosAReduzir}");
Console.WriteLine($"pontos a acrescentar no destino...: {PontosAAcrescentar}");