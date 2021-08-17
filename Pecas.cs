using System;
using UnityEngine;

public class Pecas{
	
	public const[] Cores  {get;}
	public const[] Formas {get;}
	
	public Pecas(const[,] tecla, const[,] cor, const[,] forma)
	{
		this.Cores = cor;
		this.Formas = forma;
	}
	
	public void Desenha()
	{
		//Ele utiliza as cores e formas determinadas para desenhar a peça
	}
	
}