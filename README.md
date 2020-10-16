# Dungeon Crawl
![img](https://i.imgur.com/d6wjMQV.png)
![img](https://i.imgur.com/dF0uxxW.png)
![img](https://i.imgur.com/SXNtqZv.png)
## Project goals

- Get more practice in OOP
- Design patterns: layer separation (All of the game logic, i.e., player
  movement, game rules, and so on), is in the `logic` package, completely
  independent of user interface code. In principle, you could implement a
  completely different interface e.g. terminal, web, Virtual Reality, etc. for
  the same logic code.)

## Tasks


1. Understand the existing code and class diagram so you can make changes. You should do this before planning everything else. It will help you understand what is going on.

    - Student has drawn a class diagram (classes, fields, methods and inheritance) on paper, or whiteboard.
    - Students has an Entity Relationship diagram (connections between classes, 1-1, 1-many...) on paper, or whiteboard.

2. Create a game logic which restricts the movement of the player so s/he cannot run into walls and monsters.

    - The hero is not able to move into walls.
    - The hero is not able to move into monsters.

3. There are items lying around the dungeon. They are visible in the GUI.

    - There are at least 2 item types, for instance a key, and a sword.
    - There can be one item in a map square.
    - A player can stand on the same square as an item.
    - The item has to be displayed on screen (unless somebody stands on the same square)

4. Create a feature that allows the hero to pick up an item.

    - There is a "Pick up" button on the right side of screen.
    - After the player clicks the button, the item the hero is standing on should be gone from map.

5. Show picked up items in the inventory list.

    - There is an `Inventory` list on the screen.
    - After the hero picks up an item, it should appear in inventory.

6. Make the hero to able to attack monsters by moving into them.

    - Attacking a monster removes 5 health points. If health of a monster goes below 0, it dies and disappears.
    - Create a feature where the hero attack a monster, and it doesn't die, it also attacks the hore at the same time (but is a bit weaker, and only removes 2 health).
    - Having a weapon should increase your attack strength.
    - Different monsters have different health and attack strength.

7. Create doors in the dungeon that open by using keys.

    - There are two new square types, closed door, and open door.
    - The hero cannot pass through a closed door, unless it has a key in his/her inventory. Then it becomes an open door.

8. Create three different monster types with different behaviors.

    - There are at least three different monster types with different behaviors.
    - One type of monster does not move at all.
    - One type of monster moves randomly. It cannot go trough walls or open doors.

9. [OPTIONAL] Create a more sophisticated movement AI.

    - One type of monster moves around randomly and teleports to a random free square every few turns.
    - A custom movement logic is implemented (like Ghosts that can move trough walls, monster that chases the player, etc.)

10. Create maps that have more varied scenery. Take a look at the tile sheet (tiles.png). Get inspired!

    - At least three more tiles are used. These can be more monsters, items, or background. At least one of them has to be not purely decorative, but have some effect on gameplay.

11. [OPTIONAL] Allow the player to set a name for my character. This name will also function as a cheat code!

    - There is a `Name` label and text field on the screen.
    - If the name given is one of the game developers' name, the player can walk through walls.

12. Add the possibility to add more levels.

    - There are at least two levels.
    - There is a square type "stairs down". Entering this square moves the player to a different map.

13. Implement bigger levels than the game window.

    - Levels are larger than the game window (for example 3 screens wide and 3 screens tall).
    - When the player moves the player character stays in the center of the view.

## Background materials

- :open_book: [Perlin 2D engine](https://github.com/matyasf/Perlin) You dont need to dwelve into this, most of the GUI is ready.

## References

The tiles used in the game are from [Dungeon Crawl Stone Soup](https://crawl.develz.org/),
shared on [for free use](https://github.com/crawl/tiles).

## Project status
Completed, needs refactoring
