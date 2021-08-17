using System;
using UnityEngine;

public class Painel
{
	public int Tamanho{ get;}
	public int Posicao{ get; set;}
	public const[] Teclas{ get;}
	
	public Painel(int size,int p,const[,] key){
		this.Tamanho = size;
		this.Posicao = p;
		this.Teclas = key;
	}
	public static void IniciaJogo()
	{
		//limpa o painel
	}
	public static void GeraPeca()
	{
		//Gera uma peça
	}
	public static int ApagaLinha()
	{
		//Apaga uma linha preenchidea no painel e retorna a que apagou
	}
	public int MovimentaPeca()
	{
		// Altera a posição da peça, entre cair infinitamente ou para a ação do jogador. 
		// Retorna o valor de p, que será utilizado para definir a posição da peça
	}
	public static void VerificaPeca()
	{
		// Verifica a posição da peça. Se ela estiver encostada na parede, não poderá se mover. 
		// Se encostar no chão, a peça fica parada, e então, o GeraPeca() ocorre novamente.
	}
	public static int Anima()
	{
		// Utiliza o atributo velocidade do jogo para definir 
		// o intervalo de frames em que a tecla irá cair automaticamente
	}
	public static void GameOver()
	{
		//Fim de jogo, leva ao IniciaJogo() 
	}
}