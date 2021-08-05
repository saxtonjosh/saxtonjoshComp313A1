// Fill out your copyright notice in the Description page of Project Settings.


#include "Crystal_Actor.h"

// Sets default values
ACrystal_Actor::ACrystal_Actor()
{
 	// Set this actor to call Tick() every frame.  You can turn this off to improve performance if you don't need it.
	PrimaryActorTick.bCanEverTick = true;

}

// Called when the game starts or when spawned
void ACrystal_Actor::BeginPlay()
{
	Super::BeginPlay();
	
}

// Called every frame
void ACrystal_Actor::Tick(float DeltaTime)
{
	Super::Tick(DeltaTime);

}

