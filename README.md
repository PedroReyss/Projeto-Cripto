# Projeto: Criptografia de Mensagens com Matrizes 🔒🧮
## Descrição Geral
Projeto desenvolvido no **1º semestre do Bacharelado em Engenharia da Computação**, com o objetivo de aplicar conceitos de **Algoritmos e Álgebra Linear** para criar um sistema seguro e eficiente de **criptografia de mensagens**.

## Objetivo do Projeto
Desenvolver um programa que utiliza operações matriciais para:

--> **Codificar** mensagens, transformando-as em um **formato seguro e protegido.**

--> **Decodificar** mensagens, retornando-as ao seu formato original quando fornecida a senha correta.

## Como Funciona?
### 🔐 Codificando uma Mensagem
#### 1.Entrada da mensagem:

--> O programa recebe a **mensagem do usuário** e a **converte em números.**
--> Esses números são organizados em várias **matrizes 2x2** (completando espaços vazios, se necessário).
#### 2.Criação da matriz de senha:

--> A senha fornecida é transformada em uma matriz 2x2 utilizando o **Teorema de Jacob.**

--> Esta matriz é cuidadosamente construída para manter seu **determinante igual a 1**, garantindo que o processo seja **reversível.**
#### 3.Multiplicação de matrizes:

--> Cada matriz criada na etapa 1 é multiplicada pela matriz de senha, gerando uma sequência de **matrizes criptografadas.**
#### 4.Mensagem criptografada:

--> **As matrizes resultantes** são convertidas de volta em **texto codificado** e retornadas ao usuário.
### 🔓 Decodificando uma Mensagem
#### 1.Transformação inicial:

--> A mensagem codificada e a senha são convertidas em suas **respectivas matrizes.**
#### 2.Inversão da senha:

--> **A matriz da senha** é transformada no **seu inverso** para reverter o processo de codificação.
#### 3.Multiplicação inversa:

--> As matrizes criptografadas da mensagem são **multiplicadas pelo inverso da matriz de senha**, revelando as matrizes originais.
#### 4.Reconstrução da mensagem:

--> As matrizes decodificadas são **onvertidas novamente em texto**, retornando a **mensagem original ao usuário.**

## Destaques do Projeto
**Criptografia Simples e Eficiente:** Sistema baseado em matrizes que garante segurança e praticidade.

**Reversibilidade Garantida:** Uso do determinante unitário assegura que o processo de codificação e decodificação funcione perfeitamente.

**Interface Intuitiva:** Desenvolvido com Windows Forms, o programa proporciona facilidade de uso ao usuário.

**Integração de Matemática e Computação:** Excelente exemplo da aplicação de álgebra linear em soluções computacionais.

