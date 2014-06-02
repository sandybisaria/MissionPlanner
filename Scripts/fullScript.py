#Reads from the instructions file from the image processing and then executes the appropriate command

def getDiff(one, two):
	difference = two - one
	while (difference < -180):
		difference += 360
	while (difference > 180):
		difference -= 360
	return difference

print 'Start Script'
for chan in range(1,9):
    Script.SendRC(chan,1500,False)
Script.SendRC(3,Script.GetParam('RC3_MIN'),True)

print 'here'
'''
Script.Sleep(2000)
Script.SendRC(3,1000,False)
Script.SendRC(4,2000,True)
cs.messages.Clear()
Script.WaitFor('ARMING MOTORS',30000)
Script.SendRC(4,1500,True)
print 'Motors Armed!'
'''
print 'hi'


print 'starting main loop'

file = open("videoDirections.txt", "r")
instruction = file.read()
file.close()
print 'hi ' + instruction

if(instruction == "straight"):
	Script.SendRC(3, 1400, True)
	Script.SendRC(2,1400,True) #Tilt down
	Script.Sleep(500)
elif(instruction == "right"):
	initial = cs.yaw
	new = cs.yaw+90	
	print "yaw:"+str(cs.yaw)
	print "new:"+str(new)
	Script.SendRC(3,1450,True)
	Script.SendRC(4,1750, True)
	print 'starting right loop'
	while(getDiff(cs.yaw, new) > 0):
		print str(cs.yaw) + "  |  " + str(new)
		Script.Sleep(600)
	Script.SendRC(4, 1450, True)
	Script.Sleep(500)
elif(instruction == "left"):
	initial = cs.yaw
	new = cs.yaw-90	
	print "yaw:"+str(cs.yaw)
	print "new:"+str(new)
	Script.SendRC(3,1450,True)
	Script.SendRC(4,1325, True)
	print 'starting left loop'
	while(getDiff(cs.yaw, new) < 0):
		print str(cs.yaw) + "  |  " + str(new)
		Script.Sleep(600)
	Script.SendRC(4, 1490, True)
	Script.Sleep(500)
else:#(instruction == "stop")
	print 'setting to althold'
	Script.ChangeMode("AltHold")
#Script.ChangeMode("LAND")
print 'done loop'
Script.Sleep(2000)



Script.SendRC(3,1500,True)
Script.Sleep(5000)

for chan in range(1,9):
	Script.SendRC(chan,0,True)
#while cs.alt > 0.5:
# Script.SendRC(3,1000,False)
# Script.SendRC(4,1000,True)
# Script.WaitFor('DISARMING MOTORS',30000)
# Script.SendRC(4,1500,True)
# print 'Motors Disarmed!'

Script.ChangeMode("AltHold")
