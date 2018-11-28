#pragma once
#include "System.h"
#include <iostream>

#include "GL/glew.h"
#include "GLFW/glfw3.h"
#include "GL/glut.h"

class Graphics : System
{
public:
	void Initialize();

	void Update(float dt);

	void CreateWindowTest();

	// REMOVE
	void TriangleTesting(void);
	GLuint LoadShaders(const char* vertex_file_path, const char* fragment_file_path);

private:

	GLFWwindow* window;
	GLuint programID;	

};