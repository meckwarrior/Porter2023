Questões
1. Como você implementou a função que retorna a representação por extenso do número no desafio 1? Quais foram os principais desafios encontrados?
	Eu fiz uma leitura do número de trás para frente, já convertendo para texto em um lista de textos. Depois, peguei a lista de textos e li de trás para frente para que ficasse o texto correto.
	Os principais defios foram:
		Validar quando o texto era plural ou singular;
		Tratar a variação do uso de "cem" e do "cento"; 
		Colocar uma contagem correta para incluir o mil, milhão e bilhão;
		Ignorar a contagem das casas de milhar quando tudo era zero, por exemplo, em 1.000.000;
		Realizar os principais casos de testes para eliminar qualquer possibilidade de erro, pois seria inviável escrever todos os testes de caso possíveis.

2. Como você lidou com a performance na implementação do desafio 2, considerando que o array pode ter até 1 milhão de números?
	Eu usei um laço que lê o array em um uníca passada. Desta forma, fazendo com que a complexidade do algorítimo seja O(n) e tenha uma boa performance com arrays grandes.

3. Como você lidou com os possíveis erros de entrada na implementação do desafio 3, como uma divisão por zero ou uma expressão inválida?
	Para a expressão inválida, eu utilizei a técnica de Expressão Regular (Regex) para validar o conteúdo da expressão.
	No caso da divisão por zero, durante a resolução da expressão, eu verifico a operação de divisão e retorno um erro caso ocorra a divisão por zero.

4. Como você implementou a função que remove objetos repetidos na implementação do desafio 4? Quais foram os principais desafios
encontrados?