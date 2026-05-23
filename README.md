# Zick.GameScheduler
This is an automated game server scheduler for Automobilista 2 by Reiza Studios. \
Part of a thesis work for Óbuda University.

## Preparations
It is recommended to use Docker with this program, but the bare minimum requirements are:
- Any database provider that can manage relations (i.e.: PostgreSQL, MS SQL, etc.) 
- Ansible on the host running the scheduler
- Network access to a Docker Swarm managing instances of AMS2 servers

## Notes
- For consistency across game updates, the identifying strings used by the game are separated from the database entries 
  in order to not create inconsistencies caused by game updates.