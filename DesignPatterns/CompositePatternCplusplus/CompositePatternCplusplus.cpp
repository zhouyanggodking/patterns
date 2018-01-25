// CompositePatternCplusplus.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "CDirectory.h"
#include "CImageFile.h"
#include "IFileComponent.h"
#include "CTextFile.h"
#include <vector>

void process(std::shared_ptr<IFileComponent> component)
{
	component->move();
}


int _tmain(int argc, _TCHAR* argv[])
{
	std::shared_ptr<CTextFile> textFile1{ new CTextFile{ "godking_text_file" } };
	std::shared_ptr<CImageFile> imageFile1{ new CImageFile{ "godking_image_file" } };

	std::vector<std::shared_ptr<IFileComponent> > vec;
	vec.push_back(textFile1);
	vec.push_back(imageFile1);

	std::shared_ptr<CDirectory> directory1{ new CDirectory{ "godking_directory", vec } };

	std::shared_ptr<CTextFile> textFile_ocean{ new CTextFile{ "ocean_text_file" } };
	std::shared_ptr<CImageFile> imageFile_ocean{ new CImageFile{ "ocean_image_file" } };

	//treat every composite compoent uniformly
	process(textFile_ocean);
	process(imageFile_ocean);
	process(directory1);

	return 0;
}

