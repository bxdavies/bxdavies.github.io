function particlesStart()
{
    Particles.init(
        {
            selector: '.background',
            connectParticles: true,
            color: ['#FF8C00', '#018574'],


            responsive: [
                {

                    breakpoint: 768,
                    options:
                        {
                            maxParticles: 75,
                            connectParticles: true
                        }
                },
                {
                    breakpoint: 425,
                    options:
                        {
                            maxParticles: 50,
                            connectParticles: true
                        }
                },
                {
                    breakpoint: 320,
                    options: {
                        maxParticles: 15,
                        connectParticles: true

                    }
                }
            ]
        });
}

