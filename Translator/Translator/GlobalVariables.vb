Module GlobalVariables
    Public usrLanguage As String
    Public LN As Integer
    Public TN As Integer
    Public usrName As String
    Public transLanguage As String
    Public uibClear = {"Clear", "Clair", "Claro", "Claro"}
    Public uibExit = {"Exit", "Sortie", "Salida", "Saída"}
    Public uibHome = {"Home", "Maison", "Casa", "Casa"}
    Public uibNext = {"Next", "Suivant", "Siguiente", "Seguinte"}
    Public uibNo = {"No", "Non", "No", "Não"}
    Public uibOptions = {"Options", "Les Options", "Opciones", "Opções"}
    Public uibReset = {"Reset", "Remettre", "Reajustar", "Restabelecer"}
    Public uibYes = {"Yes", "Oui", "Sí", "Sim"}
    Public uilHello = {"Hello", "Bonjour", "Hola", "Olá"}
    Public uilPhrases = {"Phrases", "Phrases", "Frases", "Frases"}
    Public uilQuit = {"Are you sure you want to exit?", "Êtes-vous sûr de vouloir quitter?", "¿Seguro que quieres salir?", "Tem certeza de que deseja sair?"}
    Public uilSelectLang = {"Please select a language:", "Sélectionnez une langue:", "Seleccione un idioma:", "Selecione um idioma:"}
    Public uilTrans = {"Translation", "Traduction", "Traducción", "Tradução"}
    Public uilName = {"What is your name?", "Quel est votre nom?", "Cuál es tu nombre?", "Qual é o seu nome?"}
    Public uiLanguages = {{"English", "Anglais", "Inglés", "Inglês"},
                          {"French", "Français", "Francés", "Francês"},
                          {"Spanish", "Espagnol", "Español", "Espanhol"},
                          {"Portuguese", "Portugais", "Portugués", "Português"}}
    Public Language = {"English", "Français", "Español", "Português"}
    Public Phrases = {{"Where are the nearest toilets?", "Où sont les toilettes les plus proches?", "¿Dónde están los baños más cercanos?", "Onde estão os banheiros mais próximos?"},
                      {"How do I get to ...", "Comment puis-je aller à ...", "Cómo llego a ...", "Como faço para chegar até ..."},
                      {"Where is the nearest", "Où est le plus proche", "¿Dónde está el más cercano", "Onde está o mais próximo"},
                      {"Can I order a ...", "Puis-je commander un ...", "¿Puedo pedir una ...", "Posso pedir um ..."},
                      {"I would like", "Je voudrais", "Me gustaría", "Eu gostaria que"},
                      {"I am going to ...", "Je vais ...", "Yo voy a ...", "Eu vou ..."},
                      {"Can I get a ticket to ...", "Puis-je obtenir un billet pour ...", "¿Puedo obtener un boleto para ...", "Posso obter um bilhete para ..."},
                      {"How much is that?", "Combien est-ce", "¿Cuánto es eso?", "Quanto é isso?"},
                      {"Do you speak", "Parlez-vous", "¿Hablas", "Você fala"},
                      {"I don't speak", "Je ne parle pas", "Yo no hablo", "Eu não falo"}}
    Public Transport = {{"train station", "la gare", "la estación de tren", "a estação de trem"},
                        {"bus stop", "l'arrêt de bus", "la parada de autobús", "ponto de ônibus"},
                        {"ferry wharf", "le quai de traversier", "el muelle del ferry", "o cais da balsa"},
                        {"taxi rank", "la station de taxis", "la parada de taxis", "o ponto de táxi"}}
    Public Numbers = {{"one", "une", "uno", "um"},
                      {"two", "deux", "dos", "dois"},
                      {"three", "trois", "tres", "três"},
                      {"four", "quatre", "cuatro", "quatro"},
                      {"five", "cinq", "cinco", "cinco"},
                      {"six", "six", "seis", "seis"},
                      {"seven", "sept", "siete", "sete"},
                      {"eight", "huit", "ocho", "oito"},
                      {"nine", "neuf", "nueve", "nove"},
                      {"ten", "dix", "diez", "dez"}}
    'Third Row needs [Transport] + "?"
    'Fifth Row needs [Number] + "?"
    'Ninth Row needs usrLanguage + "?"
    'Tenth Row needs [Language] + "?"





End Module
