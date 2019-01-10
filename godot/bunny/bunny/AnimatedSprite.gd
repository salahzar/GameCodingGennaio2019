extends AnimatedSprite

func updateAnimation(motion):
	if motion.y < 0:
		play("salta")
	elif motion.x > 0:
		play("running right")
		flip_h = false
	elif motion.x < 0:
		play("running right")
		flip_h = true
	else:
		play("default")
