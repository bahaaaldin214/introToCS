# CS1210 HW1
#
# I certify that this file contains only my own work. I also certify
# that I have not shared the contents of this file with anyone in 
# any form.
#
# Edit the following function definition, replacing the word
# 'hawkid' with your own hawkid.
#
# Note: Your hawkid is the login name you use to access ICON, and not
# your firstname-lastname@uiowa.edu email address.
#
def hawkid():
    return(["hawkid"])

######################################################################
# You will require one or more functions from the random module; here,
# we'll just import all of them.
from random import *

######################################################################
# Specification: flip(p) flips a (weighted) coin. Returns True if a
# randomly generated float between 0 and 1 (inclusive) is less than or
# equa to the specified probability p.
#
# The default value of p is 0.5, that is, a fair coin that returns
# True or False with equal probability.
#
# Example:
#   >>> len([ i for i in range(1000) if flip() ])
#   496
#   >>> len([ i for i in range(1000) if flip(0.01) ])
#   13
#
def flip(p=0.5):
    pass			# FIX THIS

######################################################################
# Specification: newPop(N,I,vp,de,di) creates a new population
# agents. A population is an N-element tuple of agents, where each
# agent is represented by a dictionary with two entries. The 'state'
# of the agent (-1 <= s <= di+de) represents that agent's current
# disease condition, while the agent's 'vaccine' status (a Boolean)
# represents whether the agent has been vaccinated or not.
#
# Returns a tuple of agent dictionaries, where I agents, selected at
# random, are initially infected (disease state = di+de+1); all other
# agents are marked as susceptible (disease state = -1). The
# vaccination status of each agent is randomly set to True with
# probability vp, else False.
#
# Example:
#   >>> newPop(8, 1, 0.2, 3, 5)
#   ({'state': -1, 'vaccine': False}, {'state': 9, 'vaccine': True},
#    {'state': -1, 'vaccine': True}, {'state': -1, 'vaccine': False},
#    {'state': -1, 'vaccine': False}, {'state': -1, 'vaccine': False},
#    {'state': -1, 'vaccine': False}, {'state': -1, 'vaccine': False})
#
# Note that 2 agents were vaccinated, approximately 20% (here, 16%) of
# the 8 agents in the population, and that agent 1 is the single
# randomly chosen infected agent. Each call to newPop() would produce
# a new randomly generated population.
#
def newPop(N, I, vp, de, di):
    pass			# FIX THIS

######################################################################
# Specification: update(pop, rp) is called at the beginning of each
# simulation day to update each agent’s infection status. Agents who's
# infection state is 1 (i.e., at the end of their infectious period)
# are set to 0 (recovered state) with probability rp, and otherwise
# set to -1 (susceptible state). All other infectious agents have
# their infection state reduced by 1. Returns the number of active
# infections remaining.
#
def update(pop, rp):
    pass			# FIX THIS

######################################################################
# Specification: sim(N=100, I=1, m=5, vp=0, tp=(0.02, 0.01), de=3,
# di=5, rp=0.5, max=100, verbose=False) returns a list of integers,
# where each integer represents the number of infections on the
# corresponding simulation day (i.e., the pandemic curve). There are a
# large number of parameters, all with default values:
#   N: number of agents in the simulation
#   I: number of infections during simulation; initially,
#      the number of infected agents on day 1.
#   m: mixing parameter is the max number of daily interactions initiated
#      by a given agent: randint(0,m) generates a given day's tally.
#   vp: probability that an agent has been vaccinated
#   tp: tuple of transmission probabilities; first value corresponds
#       to the shedding rate while exposed, the second to the shedding
#       rate while infected (generally higher).
#   de: number of days agent remains in exposed state
#   di: number of days agent remains in infected state
#   rp: probability of recovery (as opposed to becoming susceptible again)
#   max: failsafe simulation time limit, in days
#   verbose: Boolean value toggles user feedback
#
# A few more words about how we use our simple infection model (see
# Carrat et al, 2008).  People are exposed for de days (the exposed
# period), then infected for di additional days (the infected period):
# they are infectious (that is, they can infect others) while they are
# either exposed or infected.  We'll use a "daily countdown" to model
# each agent's disease state.
#
# Agents generally start the simulation as susceptible, that is, a
# status of -1. If they are infected on day t, we assume their exposed
# period runs for de days starting the next day, t+1, and then their
# infected period starts on day t+de and runs for di days. At the
# beginning of each day, update() updates each agent's infection
# status.
#
# Carrat et al. (2008) indicate E~2 and I~7 for influenza, so let's
# see a concrete example how this works. At infection on dy t, we set
# the agent's state to di+de+1 (the extra 1 ensures the agent enters
# the infectious range on the day following infectoin, after the
# beginning-of-day status update). After the infection has run its
# course, update() flips a coin to decide if the agent is now immune
# (recovered, 0) or becomes suscptible once again (-1).
#
# If I=7, E=2:
#   SUS REC                   I    I+E I+E+1
#     |  |                    |     |   |
#    -1  0  1  2  3  4  5  6  7  8  9  10
#     .  . |===================||====| .   <= days
#
def sim(N=100, I=1, m=5, vp=0, tp=(0.01, 0.02), de=3, di=5, rp=0.5, max=100, verbose=False):
    # First, we’re going to define a couple of hidden "helper" logical
    # functions that will make it easier for the reader to understand
    # the conditions being tested. Each function returns a Boolean
    # depending on the disease status of agent i.

    # Specification: susceptible(i) returns True if and only if agent
    # i is susceptible (unvaccinated and has state counter set to -1).
    #
    def susceptible(i):
        pass			# FIX THIS

    # Specification: exposed(i) returns True if and only if agent i is
    # exposed (has state counter between di and di+de).
    #
    def exposed(i):
        pass			# FIX THIS

    # Specification: infected(i) returns True if and only if agent i
    # is exposed (has state counter between 0 and di).
    #
    def infected(i):
        pass			# FIX THIS

    # Specification: infectious(i) returns True if and only if agent i
    # is infectious, that is, either infected or exposed.
    #
    def infectious(i):
        pass			# FIX THIS

    # Specification: recovered(i) returns True if and only if agent i
    # is in the recovered state.
    #
    def recovered(i):
        pass			# FIX THIS

    # Create agents.
    pop = newPop(N, I, vp, de, di)

    # Good to go, now run the simulation. We’ll use curve, a list, to
    # keep track of how many infecteds there are each day: curve[0]
    # starts s the number of initially infected agents on day 0.
    curve = [I]

    # Run the simulation (i.e., keep looping) while there are
    # infecteds remaining (that is, while curve[-1] > 0) or until you
    # hit the failsafe simulation limit, max. We establish the max
    # limit because it is possible to set up an SIS simulation where
    # the infection does not completely disappear (i.e., it becomes
    # endemic, or runs through a series of pandemic cycles).
    while max > 0:
        # Beginning-of-day agent status update: returns the number of
        # active infections on the new day, which we append to the
        # curve list.
        curve.append(update(pop, rp))

        # If verbose is True, show user feedback.
        if verbose:
            print("Day {}: {} of {} agents infected.".format(len(curve)-1, curve[-1], N))

        # Quit the simulation if there are no infections left.
        if curve[-1] == 0:
            print("Pandemic extinguished: {} days, {} infecteds, attack rate is {:3.1f}%.".format(len(curve), I, (100*I)/N))
            pass			# FIX THIS
        
        # Now we come to the heart of the simulation, where the day's
        # transmission events are modeled and then simulated. The
        # basic idea is that we scan the population, and for each
        # infected agent, we model some random number of simulations
        # (governed by m, the daily mixing parameter) and, if the
        # sampled agent is susceptible, we flip a coin to determine if
        # a new infection occurs. For each new infection, update the
        # appropriate agent's status as well as I, the total infection
        # count.
        for i in range(N):
            # Only worry about infectious agents
            if infectious(i):
                # Here is where the action happens.
                pass			# FIX THIS

        # Update failsafe simulation limit
        max = max -1
    else:
        print("Pandemic persists: {} days, {} infecteds, attack rate is {:3.1f}%.".format(len(curve), I, (100*I)/N))

    # Return simulation curve.
    return(curve)
