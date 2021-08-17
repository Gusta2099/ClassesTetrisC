using System
using UnityEngine;

public class Jogo
{
	//atributos de instancia

	public int Pontuacao { get; set;} 
	public int Linhas { get; set;}
	public int Nivel { get; set;}
	public int Velocidade { get; set;}
		
	//define o construtor
	public Jogo(int pontos, int[,] linhas, int nivel, int vel)
	{
		this.Pontuacao = pontos;
		this.Linhas = linhas;
		this.Nivel = nivel;
		this Velocidade = vel;
	}
	public CalculaLinha()
	{
		//calcula a quantidade de linhas de acordo com as que o jogador deletou
	}
	public AlteraNivel()
	{
		//Altera o nivel atual de acordo com a pontuação do jogador
	}
	
}