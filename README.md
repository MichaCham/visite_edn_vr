# VISITE EDN

## Objectif du projet

L’objectif de ce projet est de pouvoir proposer au client une visite virtuelle et interactive de ses bâtiments. Il pourra l’utiliser lors des salons étudiant ou encore lors de l’ouverture des différents locaux de l’établissement.
Il sera aussi possible de lancer des quêtes pour rendre la visite un peu plus interactive, chacune des quêtes sera en rapport avec les formations données au sein de l’établissement.

## Utilisateurs cibles

Ce projet a pour objectif de proposer aux futurs et actuels étudiants une visite en réalité virtuelle. Le corps enseignant est aussi une cible potentielle car ce projet permet de mettre en avant les locaux mais aussi le savoir-faire appris au sein de l’école.

## Roadmap

Attentes à la fin du Projet :
- [ ] Caméra hors VR
- [x] Pouvoir faire la visite sans les quêtes
- [ ] Pourvoir faire la visite avec des quêtes
- [x] La visite doit-être portable sur différentes plateformes 
- [x] Pouvoir se déplacer dans les bâtiments C et D
- [x] Avoir définis des tests utilisateurs 
- [x] Utiliser des assets open source
- [x] Utiliser des graphismes dit “low poly” pour simplifier l’exécution sur les différents appareils
- [x] Utiliser un système de déplacement ne générant pas de sensation de nausée à l'utilisateur, pour améliorer confort du joueur

## Environnement de développement
|Type            |Type        |
|----------------|------------|
| **Logiciel**   |Unity       |
| **Casque  VR** |Meta Quest 2|

## Installation et lancement du projet

### Prérequis


- Avoir Unity sur sa machine, de préférence la version la plus récente
- Avoir un Android SDK
- Avoir un Casque de réalité virtuelle fonctionnant sous android (puvant lire des .apk)

### Instalation

- Cloner le repository git
- Ouvrir Unitty Hub, Aller sur l'onglet Projet, cliquer sur Add, sélectionner le dossier contenant les fichiers préent sur le git (visite_edn_vr)
- Cliquer sur le nom du projet dans unity hub pour le lancer 
![image](https://github.com/MichaCham/visite_edn_vr/assets/118127498/f59a3ca0-133a-418f-8b79-0d39e384f302)
- attendre que le projet se lance sur unity editor.
- Dans les assets, ouvrir Scenes et ouvrir "EDN", ourant donc la scène principale
![image](https://github.com/MichaCham/visite_edn_vr/assets/118127498/d868485f-480e-4e9c-89e5-be6eefb83703)

  
### Lancement

1 ère option : si le casque Vr peut se connecter directement a Unity
- Dans unity Editor, cliquer sur file, Build Settings...
- Sélectionner la scène "EDN" a build
- Dans platform, sélectionner Android,  si ce n'est pas la latefrme actuellement en cours d'utilisation, cliquer sur "Switch Platform"
  ![image](https://github.com/MichaCham/visite_edn_vr/assets/118127498/3da4a7d6-816f-44e1-b819-b5593ef247d3)
- Une fois que la plateforme a été switchée, dans "Run Device", sélectionner le casque VR a utiliser, puis appuyer sur build and run
  ![image](https://github.com/MichaCham/visite_edn_vr/assets/118127498/ad5d9b2b-727e-4879-b42f-e04e5972cb66)
- nommer l'apk comme vous le désirez, dans notre cas nous avons choisit de la nommer "edn_visite"
- Attendre que le build se termine (le premier build peut être long) et enfiler le casque VR !

2 ème option : 
- Installer l'APK présente dans le repository git dansle casque VR et l'exécuter !

### Jouer au Jeux
- Pour se déplacer, utiliser la gachette droite
- Pour attraper un Objet, utiliser les Grab Button Gauche et Droit

