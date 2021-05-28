# UnityDissolveEffect
Repository for the Dissolve Effect in the URP Unity

# Dissolve Shader

> Note: Use the DissolveEffect Script in the asset with it.

- To Create a Material out of the Dissolve Shader:
1. Right Click on the Dissolve Shader in Assets
2. Create
3. Material


- Attach  this material onto the object. Now expand the material attached to the game object  you will see multiple components:

1. Albedo - For the Albedo Texture to be applied
2. Metallic - For the Metallic to be applied
3. Normal -For the Normal to be applied
4. Occlusion - For the Occlusion to be applied
5. Color - The color of shade to be added in adition to Albedo (**Default**: black) (**Reccommended**: White if no albedo texture used)
6. EdgeColor - The color of the edge you want to see when the dissolve occurs
7. Dissolve (Slider) - Slider to check dissolve effect. 0 for complete dissolve 1 for no dissolve
8. EdgeWidth - Width of the edge
9. Noise Value - Varying this varies the noise level rendering different texture
10. Smoothness - For texture smoothness
11. Tiling - For texture tiling
12. Offset - For texture offset
> Note: Create a new material from the shader for each object. Use Texture for Albedo, Normal, Mettallic and Occlusion where possible for better quality.

- Attach the DissolveEffect Script to the object where you attached the material.
- Go to the DissolveShader and look at the inspector and check the properties
- Search for the value Dissolve and look at its key should be something like "Vector1_CC876C20"
- Add this to DissolveVal in the DissolveEffect Script
- Set Max Appearance Value to 100 for complete appearance, feel free to tweak these values
- Set Appearane Speed as you wish
- After Adding to MRTK Buttons Call:
 1. Function InitiateAppearance() to start appearance effect
 2. Function InitiateDisappearance() to start disappearance effect



# Scale Effect

- Add the ScaleEffect script to the object to scale
- Keep Scale Value 0
- Set MaxScaleValue (**Keep this small in the start around 0.01 and tweak as necessary**)
- Set ScaleSpeed (**Should be less than Max  Scale Value**)
-  After Adding to MRTK Buttons Call:
 1. Function InitiateScaling() to start auto scaling effect
 2. Function InitiateDescaling() to start auto descaling effect
