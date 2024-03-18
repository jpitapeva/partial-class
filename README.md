# partial-class

Classes parciais
</br>Há várias situações em que a divisão de uma definição de classe é desejável:

</br>Declarar uma classe em arquivos separados permite que vários programadores trabalhem nela ao mesmo tempo.
</br>Você pode adicionar código à classe sem precisar recriar o arquivo de origem que inclui a origem gerada automaticamente. O Visual Studio usa essa abordagem quando cria Windows Forms, código de wrapper de serviço Web e assim por diante. Você pode criar código que usa essas classes sem precisar modificar o arquivo que o Visual Studio cria.
</br>Os geradores de origem podem gerar funcionalidade extra em uma classe.
</br>Para dividir uma definição de classe, use o modificador de palavra-chave partial, como mostrado aqui:
