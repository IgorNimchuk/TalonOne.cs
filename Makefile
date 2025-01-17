BUILD_DIR=src/TalonOne
VERSION=$(shell grep -om1 -E '^\[assembly: AssemblyVersion\("[0-9\.]+"\)\]$$' $(PWD)/$(BUILD_DIR)/Properties/AssemblyInfo.cs | sed 's/\[assembly: AssemblyVersion("\(.*\)")\]/\1/')

clean:
	rm -rf $(PWD)/$(BUILD_DIR)/TalonOne.$(VERSION).nupkg

build: clean
ifeq ($(VERSION),)
	@echo "***\033[0;31mERROR:\033[0m NO VERSION COULD BE EXTRACTED. Check out the AssemblyInfo.cs file"
	@exit 1
endif
	docker run \
		--rm \
		-v $(PWD):/tmp/talon-client \
		-w "/tmp/talon-client/$(BUILD_DIR)" \
		mono:6 \
		nuget pack -Prop Configuration=Release -IncludeReferencedProjects -properties version=$(VERSION)

publish: clean
ifeq ($(VERSION),)
	@echo "***\033[0;31mERROR:\033[0m NO VERSION COULD BE EXTRACTED. Check out the AssemblyInfo.cs file"
	@exit 1
endif
ifeq ($(apiKey),)
	@echo "***\033[0;31mERROR:\033[0m NO apiKey WAS NOT PROVIDED."
	@exit 1
endif
	docker run \
		--rm \
		-v $(PWD):/tmp/talon-client \
		-w "/tmp/talon-client/$(BUILD_DIR)" \
		mono:6 \
		/bin/bash -c "nuget pack -Prop Configuration=Release -IncludeReferencedProjects -properties version=$(VERSION) && \
			nuget push TalonOne.$(VERSION).nupkg $(apiKey) -Source https://api.nuget.org/v3/index.json"
