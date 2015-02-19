Module varStorage
    Public usrLanguage As String
    Public usrName As String
    Public transLanguage As String
    Public Language = {"English", "Français", "Español", "Português"}
    Public Phrases = {{"Where are the nearest toilets?", "Où sont les toilettes les plus proches?", "¿Dónde están los baños más cercanos?", "Onde estão os banheiros mais próximos?"},
                      {"How do I get to ...", "Comment puis-je aller à ...", "Cómo llego a ...", "Como faço para chegar até ..."},
                      {"Where is the nearest", "Où est le plus proche", "¿Dónde está el más cercano", "Onde está o mais próximo"},
                      {"Can I order a ...", "Puis-je commander un ...", "¿Puedo pedir una ...", "Posso pedir um ..."},
                      {"I would like", "Je voudrais", "Me gustaría", "Eu gostaria que"},
                      {"I am going to ...", "Je vais ...", "Yo voy a ...", "Eu vou ..."},
                      {"Can I get a ticket to ...", "Puis-je obtenir un billet pour ...", "¿Puedo obtener un boleto para ...", "Posso obter um bilhete para ..."},
                      {"How much is that?", "Puis-je obtenir un billet pour ...", "¿Puedo obtener un boleto para ...", "Posso obter um bilhete para ..."},
                      {"Do you speak", "Parlez-vous", "¿Hablas", "Você fala"},
                      {"I don't speak", "Je ne parle pas", "Yo no hablo", "Eu não falo"}}
    'Third Row needs [Transport] + "?"
    'Fifth Row needs [Number] + "?"
    'Ninth Row needs usrLanguage + "?"
    'Tenth Row needs [Language] + "?"




End Module
