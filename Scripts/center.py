import time
import os.path

def performFunction(stringInput):
	print stringInput

current = ""

while True:
	if (not os.path.isfile("videoDirections.lck")):
		inputFile = open("videoDirections.txt", 'r')
		temp = inputFile.read()
		if not (temp == current):
			current = temp
			performFunction(current)
		time.sleep(0.01)
		inputFile.close()