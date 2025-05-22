# Deposito_EsercizioDiGruppoC-
Stepanyuk, Rottura, Varchetta


---

# Repository Corsi

Questa repository contiene una struttura di classi per la gestione di diversi tipi di corsi.

La **classe base** è stata sviluppata **collaborativamente**, frutto di un confronto e di un ragionamento comune. È stata messa a disposizione di tutti come punto di partenza condiviso per costruire le varie specializzazioni.

Le estensioni della classe base sono state realizzate individualmente:

* La classe **CorsoMusica** 🎵 e la classe **CorsoPittura** 🎨 sono state scritte da **Stepanyuk**.
* La classe **ClasseDanza** 🩰 è stata scritta da **Rottura**.

Ogni classe rappresenta un tipo di corso con le sue caratteristiche specifiche, seguendo l’impostazione comune fornita dalla classe base.

---

Il menù dell'applicazione,completamente implementato, costituisce l'interfaccia principale per l'interazione con il sistema. La struttura del menù è stata inizialmente proposta dal componente **Rottura**, mentre gli altri due membri del gruppo hanno contribuito alla sua definizione e sviluppo attraverso un confronto collaborativo, con l'obiettivo di garantire semplicità d’uso e funzionalità adeguata alle esigenze dell’utente.

Il menù, integrato nel metodo `main`, è progettato per essere interattivo e guidare l’utente nelle principali operazioni gestionali sui corsi. Le funzionalità offerte sono le seguenti:

```
[1] Aggiungi un corso di Musica  
[2] Aggiungi un corso di Pittura  
[3] Aggiungi un corso di Danza  
[4] Aggiungi studente a un corso (tramite selezione per indice)  
[5] Visualizza tutti i corsi  
[6] Cerca corsi per nome docente  
[7] Esegui metodo speciale di un corso (selezionato per indice)  
[0] Esci
```

Nel corso dello sviluppo, in riferimento al **caso 6** (ricerca di corsi per nome del docente), il collega **Varchetta** ha suggerito l’introduzione di un metodo `equals` all’interno della classe base, al fine di evitare l’accesso diretto alle proprietà degli oggetti e rispettare i principi dell’incapsulamento. Tale suggerimento è stato accolto e verrà implementato in una successiva iterazione del progetto.

---





