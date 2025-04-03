# KATA Star-Wars

## Swapi.dev
### 1/ Ajout d'une route listant les planetes
L'API swapi.dev est une source de données REST sur l'univers Star Wars. On peut par exemple trouver des informations sur les différentes planètes: - https://swapi.dev/api/planets/1/ - https://swapi.dev/api/planets/2/ - etc.

Exemple: https://swapi.dev/api/planets/3/

{
    "name": "Yavin IV",
    "rotation_period": "24",
    "orbital_period": "4818",
    ...
}
Vous devez ajouter une nouvelle route dans l'api existante, qui permet de faire une recherche parmi les 60 planètes disponibles dans l'API swapi.dev.
Vous devrez également ajouter un projet de test unitaires et tester vos développements

Le critère de recherche est un texte libre fourni en paramètre à votre API, qui doit retourner la liste des planètes dont le nom correspond au critère (correspondance exacte sur le champ name).

### 2/ Ajout des infos des planetes dans les informations sur les bases

En vous servant des développements précédemments effectués, il vous est désormais demandé de remplacer dans les deux routes initiales ("bases"), le champs "PlanetId", par un objet "Planet" contenant les informations de la planete.
Cette fois aussi, il vous est demandé de mettre en place des tests unitaires.

### 3/ Exercices supplémentaires
En fonction du temps restant : 
1) Implémenter une recherche partielle sur le nom de la planète (et non plus une recherche exacte)
2) Ajouter une recherche par "Commander name".
3) Documenter votre API

### 4/ Questions supplémentaires
A discuter à l'oral, comment feriez-vous pour :
1) Implémentez une solution permettant à votre API de fournir un service tolérant aux pannes (Le réseau n'est pas toujours fiable, les autres API ne sont pas toujours opérationnelles.)
2) Implémenter un mécanisme d'autentification pour accéder à votre API
2) Mettre en oeuvre un monitoring permettant aux clients de votre API de connaître son état (fonctionnel, dégradé, critique...) ainsi que l'état de ses dépendances
3) Ajouter des logs
4) Proposer une solution permettant de débugger votre API localement (exemple: internet non disponible)
